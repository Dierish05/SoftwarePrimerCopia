using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCursoSoftware.Formularios
{
    public partial class FormVendedor_01 : Form
    {
        public FormVendedor_01()
        {
            InitializeComponent();
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
            if (txtCedula.TextLength == 14 && e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text == "" || txtApellidos.Text == "" || txtDireccion.Text == ""
                || txtTelefono.Text == "" || txtEmail.Text == "" || txtCedula.Text == "")
            {
                if (rbtnFemenino.Checked == false || rbtnMasculino.Checked == false)
                {
                    MessageBox.Show("Datos incompletos! porfavor complete los datos e intentelo nuevamente");

                }
                else
                {
                    //Metodo para guardar el vendedor
                    //Recordar que el estado no va, ya que se esta añadiendo el vendedor
                    //Es obvio que su estado es 1, asi que solo se le pone 1
                }
            }
            
        }
    }
}
