using ProyectoCursoSoftware.Model;
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
        Conexion con;
        public string NombreProveedor;
        private ProductoModel pm;
        public string idProveedor;
        public FormProducto_01(Conexion con)
        {
            this.con = con;
            pm = new ProductoModel(con);
            InitializeComponent();


            txtProveedor.Enabled = false;
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
