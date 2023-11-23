using ProyectoCursoSoftware.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCursoSoftware.Formularios
{
    public partial class FormCompras_02 : Form
    {
        // Importar funciones de la API de Windows para la sombra
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        [DllImport("Dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        private static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);

        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_LAYERED = 0x80000;
        private const int CS_DROPSHADOW = 0x20000;
        private const int LWA_COLORKEY = 0x1;
        private const int LWA_ALPHA = 0x2;

        Conexion con;
        private ProductoModel cm;
        public string CodProductoSeleccionado { get; set; }
        public string NombreProductoSeleccionado { get; set; }
        public FormCompras_02(Conexion con)
        {
            
            InitializeComponent();
            this.con = con;
            cm = new ProductoModel(con);
            Listar();
            ApplyShadows();
        }

        private void ApplyShadows()
        {
            // Obtener el estilo extendido actual
            int exStyle = (int)GetWindowLong(Handle, GWL_EXSTYLE);

            // Agregar el estilo de capa y sombra
            SetWindowLong(Handle, GWL_EXSTYLE, exStyle | WS_EX_LAYERED | CS_DROPSHADOW);

            // Aplicar el efecto de sombra
            int shadowValue = 2; // Ajusta este valor según tus preferencias
            DwmSetWindowAttribute(Handle, 2, ref shadowValue, sizeof(int));

            // Redondear los bordes del formulario
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            // Establecer la opacidad a 255 (completamente opaco)
            SetLayeredWindowAttributes(Handle, 0, 255, LWA_ALPHA);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != string.Empty)
            {
                cm.BusquedaProductosNombre(txtNombre.Text, dgvDatos);
            }
            else
            {
                Listar();
            }
        }
        private void Listar()
        {
            cm.listarProductos(dgvDatos);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        private void btnSeleccionar_Click_1(object sender, EventArgs e)
        {

            if (dgvDatos.SelectedCells.Count == 0)
            {
                MessageBox.Show("No tiene ningun producto seleccionado! seleccione un producto e intentelo nuevamente");
            }
            else
            {
                int indiceSeleccionado = dgvDatos.SelectedCells[0].RowIndex;
                DataGridViewCell cell = dgvDatos.Rows[indiceSeleccionado].Cells["CodProd"];
                if (cell.Value != null && cell.Value != DBNull.Value)
                {

                    CodProductoSeleccionado = cell.Value.ToString();
                    NombreProductoSeleccionado = dgvDatos.Rows[indiceSeleccionado].Cells["Nombre_del_producto"].Value.ToString();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No tiene ningun producto seleccionado! seleccione un producto e intentelo nuevamente");
                }
            }
          


          
        }
    }
}
