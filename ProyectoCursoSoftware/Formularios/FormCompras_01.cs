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

    public partial class FormCompras_01 : Form
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
        public string NombreProducto;
        public string codProducto;
        public FormCompras_01(Conexion con)
        {
            InitializeComponent();
            this.con = con;
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


        private void txtCodProducto_KeyDown(object sender, KeyEventArgs e)
        {
            // Limitar a 5 caracteres
            if (!(e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete) && txtProducto.Text.Length >= 5)
            {
                e.SuppressKeyPress = true;
            }
        }



        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            //// Permitir solo números y un punto para decimales
            //if (!((char.IsDigit((char)e.KeyValue) || e.KeyValue == (char)Keys.OemPeriod || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete) && !(e.KeyValue == (char)Keys.OemPeriod && numericUpDown1.Text.Contains("."))))
            //{
            //    e.SuppressKeyPress = true;
            //}
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtProducto.Text == "" || numericUpDown1.Value == 0 || nUpdownCantidad.Value == 0)
            {
                MessageBox.Show("Campos vacios, porfavor introduzca un dato valido!");
            }
            else
            {
                //Metodo de guardar compra
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            FormCompras_02 formCompras_02 = new FormCompras_02(con);
            formCompras_02.ShowDialog();

            if (!string.IsNullOrEmpty(formCompras_02.CodProductoSeleccionado) &&
         !string.IsNullOrEmpty(formCompras_02.NombreProductoSeleccionado))
            {

                codProducto = formCompras_02.CodProductoSeleccionado;
                NombreProducto = formCompras_02.NombreProductoSeleccionado;


                ActualizarTextBoxProveedor();
            }
        }

        private void ActualizarTextBoxProveedor()
        {

            txtProducto.Text = NombreProducto;
        }

        private void FormCompras_01_Load(object sender, EventArgs e)
        {

        }
    }
}
