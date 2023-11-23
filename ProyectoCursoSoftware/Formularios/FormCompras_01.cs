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
        Conexion con;
        public string NombreProducto;
        public string codProducto;
        public FormCompras_01(Conexion con)
        {
            InitializeComponent();
            this.con = con;
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
    }
}
