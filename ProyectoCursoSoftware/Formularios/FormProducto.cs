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
    public partial class FormProducto : Form
    {
        private Conexion con;
        private ProductoModel pm;
        public FormProducto(Conexion Con)
        {
            this.con = Con;
            pm = new ProductoModel(con);
            InitializeComponent();
            Listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormProducto_01 formProducto_01 = new FormProducto_01(con);
            formProducto_01.ShowDialog();
        }

        private void Listar()
        {
            pm.listarProductos(dgvDatos);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedCells.Count == 0)
            {
                MessageBox.Show("No tiene ningun producto seleccionado! seleccione un producto e intentelo nuevamente");
            }
            else
            {
                int indiceSeleccionado = dgvDatos.SelectedCells[0].RowIndex;
                DataGridViewCell cell = dgvDatos.Rows[indiceSeleccionado].Cells["CodProd"];
                if (cell.Value != null && cell.Value != DBNull.Value)
                {
                    FormProducto_01 formProducto_01 = new FormProducto_01(con);
                    formProducto_01.txtCodigo.Text = dgvDatos.Rows[indiceSeleccionado].Cells["CodProd"].Value.ToString();
                    formProducto_01.txtNombre.Text = dgvDatos.Rows[indiceSeleccionado].Cells["Nombre del producto"].Value.ToString();
                    formProducto_01.txtDescripcion.Text = dgvDatos.Rows[indiceSeleccionado].Cells["Descripcion del producto"].Value.ToString();
                    formProducto_01.cmbCategoria.Text = dgvDatos.Rows[indiceSeleccionado].Cells["Categoria"].Value.ToString();
                    formProducto_01.txtProveedor.Text = dgvDatos.Rows[indiceSeleccionado].Cells["Proveedor"].Value.ToString();
                    formProducto_01.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No tiene ningun producto seleccionado! seleccione un producto e intentelo nuevamente");
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedCells.Count == 0)
            {
                MessageBox.Show("No tiene ningun producto seleccionado! seleccione un producto e intentelo nuevamente");
            }
            else
            {
                int indiceSeleccionado = dgvDatos.SelectedCells[0].RowIndex;
                DataGridViewCell cell = dgvDatos.Rows[indiceSeleccionado].Cells["CodProd"];
                if (cell.Value != null && cell.Value != DBNull.Value)
                {

                    //Mostrar formulario de eliminar producto
                }
                else
                {
                    MessageBox.Show("No tiene ningun producto seleccionado! seleccione un producto e intentelo nuevamente");
                }
            }
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

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = DeterminarCategoria(cmbCategoria.SelectedItem.ToString());
            if (i == 1)
            {
                pm.BusquedaProductoCategoria(i, dgvDatos);
            }
            else if (i == 2)
            {
                pm.BusquedaProductoCategoria(i, dgvDatos);
            }
            else if (i == 3)
            {
                pm.BusquedaProductoCategoria(i, dgvDatos);
            }
            else if (i == 4)
            {
                pm.BusquedaProductoCategoria(i, dgvDatos);
            }
            else if (i == 5)
            {
                pm.BusquedaProductoCategoria(i, dgvDatos);
            }
            else if (i == 6)
            {
                pm.BusquedaProductoCategoria(i, dgvDatos);
            }
            else
            {
                Listar();
            }

        }


    }
}
