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
    public partial class FormProveedores_01 : Form
    {
        public FormProveedores_01()
        {
            InitializeComponent();
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
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Cammpos vacios! porfavor complete todos los campos e intentelo nuevamente");
            }
        }

        private void FormProveedores_01_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
