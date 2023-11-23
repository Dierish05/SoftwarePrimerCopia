using ProyectoCursoSoftware.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCursoSoftware.Formularios
{
    public partial class FormProveedores_01 : Form
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

        private ProveedorModel pm;
        public FormProveedores_01(ProveedorModel Pm)
        {
            this.pm = Pm;
            InitializeComponent();
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

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z) &&
                !(e.KeyCode == Keys.OemPeriod) &&
                !(e.KeyCode == Keys.Oemcomma) &&
                !(e.KeyCode == Keys.Space) &&
                !(e.KeyCode == Keys.Back) &&
                !(e.KeyCode == Keys.Delete) &&
                !(e.KeyCode == Keys.ControlKey) &&
                !(e.KeyCode == Keys.Control) &&
                !(e.KeyCode == Keys.Control || e.KeyCode == Keys.C) &&
                !(e.KeyCode == Keys.Control || e.KeyCode == Keys.V) &&
                !(e.KeyCode == Keys.Control || e.KeyCode == Keys.A) &&
                !(e.KeyCode == Keys.Home) &&
                !(e.KeyCode == Keys.End) &&
                !(e.KeyCode == Keys.Left) &&
                !(e.KeyCode == Keys.Right))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == "" || txtTelefono.Text == "" || txtEmail.Text == "" || txtDireccion.Text == "")
            {
                MessageBox.Show("Campos vacios! porfavor complete todos los campos e intentelo nuevamente");
            }
            else if(!IsValidEmail(txtEmail.Text)){
                MessageBox.Show("El correo electrónico no es válido.");
            }
            else
            {
                pm.CrearProveedor(txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtTelefono.Text);
            }
        }

        static bool IsValidEmail(string email)
        {
            // Patrón para validar el formato de un correo electrónico
            string patron = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

            // Utilizar la clase Regex para realizar la validación
            Regex regex = new Regex(patron);

            return regex.IsMatch(email);
        }

        private void FormProveedores_01_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) &&
                !(e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) &&
                !(e.KeyCode == Keys.Back) &&
                !(e.KeyCode == Keys.Delete) &&
                !(e.KeyCode == Keys.ControlKey) &&
                !(e.KeyCode == Keys.Control) &&
                //!(e.KeyCode == Keys.Control || e.KeyCode == Keys.C) &&
                //!(e.KeyCode == Keys.Control || e.KeyCode == Keys.V) &&
                //!(e.KeyCode == Keys.Control || e.KeyCode == Keys.A) &&
                !(e.KeyCode == Keys.Home) &&
                !(e.KeyCode == Keys.End) &&
                !(e.KeyCode == Keys.Left) &&
                !(e.KeyCode == Keys.Right))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
            else
            {

                if (txtTelefono.TextLength == 8 && e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete)
                {
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                }
            }
        }
    }
}
