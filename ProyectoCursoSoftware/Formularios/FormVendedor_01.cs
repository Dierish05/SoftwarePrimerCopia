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
    public partial class FormVendedor_01 : Form
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

        private VendedorModel vm;
        public FormVendedor_01(VendedorModel vm)
        {
            this.vm = vm;
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

        private void txtNombres_KeyDown(object sender, KeyEventArgs e)
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

        private void txtApellidos_KeyDown(object sender, KeyEventArgs e)
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

        private void txtCedula_KeyDown(object sender, KeyEventArgs e)
        {
            //if (txtCedula.TextLength == 14 && e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete)
            //{
            //    e.SuppressKeyPress = true;
            //    e.Handled = true;
            //}
        }

        private int DeterminarMunicipio(string a)
        {
            if (string.Equals(a, "Managua") == true)
            {
                return 1;
            }
            else if (string.Equals(a, "Esteli") == true)
            {
                return 2;
            }
            else if (string.Equals(a, "Leon") == true)
            {
                return 3;
            }
            else if (string.Equals(a, "Granada") == true)
            {
                return 4;

            }
            else if (string.Equals(a, "Masaya") == true)
            {
                return 5;
            }
            else
            {
                return 0;
            }
        }

        private char DeterminarSexo()
        {
            if (rbtnFemenino.Checked == true)
            {
                return 'F';
            }
            else if (rbtnMasculino.Checked == true)
            {
                return 'M';
            }
            else
            {
                return 'O';
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtPrimerNombre.Text == "" || txtPrimerApellido.Text == "" || txtDireccion.Text == ""
                || txtTelefono.Text == "" || txtEmail.Text == "" || txtCedula.Text == "")
            {

                MessageBox.Show("Datos incompletos! porfavor complete los datos e intentelo nuevamente");

            }
            else if (rbtnFemenino.Checked == false && rbtnMasculino.Checked == false)
            {
                MessageBox.Show("Debe seleccionar un genero");
            }
            else
            {
                int muni = DeterminarMunicipio(cmbMunicipio.SelectedItem.ToString());
                char sexo = DeterminarSexo();
                vm.CrearVendedor(txtPrimerNombre.Text, txtSegundoNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text, txtDireccion.Text, txtTelefono.Text, sexo, muni, txtEmail.Text, txtCedula.Text, txtUsuario.Text);
                vm.CrearLoginVendedor(txtUsuario.Text, txtContraseña.Text);
                this.Close();
            }


        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
