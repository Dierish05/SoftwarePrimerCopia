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
    public partial class FormProducto_01 : Form
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
        public string NombreProveedor;
        private ProductoModel pm;
        public string idProveedor;
        public FormProducto_01(Conexion con)
        {
            this.con = con;
            pm = new ProductoModel(con);
            InitializeComponent();
            ApplyShadows();

            txtProveedor.Enabled = false;
            //Hola uwu
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

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            // Limitar a 5 caracteres
            if (!(e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete) && txtCodigo.Text.Length >= 5)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            // Limitar a 40 caracteres
            if (!(e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete) && txtNombre.Text.Length >= 40)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtCodigo.Text == "" || txtDescripcion.Text == ""
                || cmbCategoria.Text == "")
            {
                MessageBox.Show("Campos incompletos! Porfavor complete todos los campos e intentelo nuevamente");
            }
            else
            {
                //Metodo guardar producto
                int cat = DeterminarCategoria(cmbCategoria.SelectedItem.ToString());
                pm.CrearProducto(txtCodigo.Text, txtNombre.Text, txtDescripcion.Text, int.Parse(idProveedor), cat);
                this.Close();
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            FormProducto_02 formProducto_02 = new FormProducto_02(con);
            formProducto_02.ShowDialog();

            if (!string.IsNullOrEmpty(formProducto_02.IdProveedorSeleccionado) &&
         !string.IsNullOrEmpty(formProducto_02.NombreProveedorSeleccionado))
            {

                idProveedor = formProducto_02.IdProveedorSeleccionado;
                NombreProveedor = formProducto_02.NombreProveedorSeleccionado;


                ActualizarTextBoxProveedor();
            }
        }

        private void ActualizarTextBoxProveedor()
        {
            txtProveedor.Text = NombreProveedor;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private int DeterminarCategoria(string a)
        {
            if (string.Equals(a, "Cargadores") == true)
            {
                return 1;
            }
            else if (string.Equals(a, "Audifonos") == true)
            {
                return 2;
            }
            else if (string.Equals(a, "Covers") == true)
            {
                return 3;
            }
            else if (string.Equals(a, "Memorias") == true)
            {
                return 4;

            }
            else if (string.Equals(a, "Protectores de pantalla") == true)
            {
                return 5;
            }
            else if (string.Equals(a, "Celulares") == true)
            {
                return 6;
            }
            else
            {
                return 0;
            }
        }
    }
}
