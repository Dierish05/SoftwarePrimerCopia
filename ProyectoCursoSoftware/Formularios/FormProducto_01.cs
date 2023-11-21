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
    public partial class FormProducto_01 : Form
    {
        public FormProducto_01()
        {
            InitializeComponent();
            //Hola uwu
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
                || cmbCategoria.Text == "" || cmbProveedor.Text == "")
            {
                MessageBox.Show("Campos incompletos! Porfavor complete todos los campos e intentelo nuevamente");
            }
            else 
            {
             //Metodo guardar producto
            }
        }
    }
}
