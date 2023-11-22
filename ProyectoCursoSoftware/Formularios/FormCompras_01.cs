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
    public partial class FormCompras_01 : Form
    {
        public FormCompras_01()
        {
            InitializeComponent();
        }

        private void txtCodProducto_KeyDown(object sender, KeyEventArgs e)
        {
            // Limitar a 5 caracteres
            if (!(e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete) && txtCodProducto.Text.Length >= 5)
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
            if (txtCodProducto.Text == "" || numericUpDown1.Value == 0 || nUpdownCantidad.Value == 0)
            {
                MessageBox.Show("Campos vacios, porfavor introduzca un dato valido!");
            }
            else
            {
                //Metodo de guardar compra
            }
        }
    }
}
