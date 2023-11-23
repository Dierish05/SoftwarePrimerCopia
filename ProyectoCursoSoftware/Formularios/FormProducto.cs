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

                    //Mostrar formulario de editar producto
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
    }
}
