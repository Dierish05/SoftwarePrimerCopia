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
    public partial class FormVenta : Form
    {
        private Conexion con;
        private InventarioModel im;
        private VentaModel vm;
        private double Total;
        public FormVenta(Conexion Con)
        {
            this.con = Con;
            im = new InventarioModel(con);
            vm = new VentaModel(con);
            InitializeComponent();
            listar();
        }

        private void btnGuardar_MouseEnter(object sender, EventArgs e)
        {
            btnGuardar.ForeColor = Color.WhiteSmoke;
            btnGuardar.BackColor = Color.FromArgb(26, 138, 94);
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            btnGuardar.ForeColor = Color.FromArgb(26, 138, 94);
            btnGuardar.BackColor = Color.WhiteSmoke;
        }

        private void btnAnular_MouseEnter(object sender, EventArgs e)
        {
            btnAnular.ForeColor = Color.WhiteSmoke;
            btnAnular.BackColor = Color.Red;
        }

        private void btnAnular_MouseLeave(object sender, EventArgs e)
        {
            btnAnular.ForeColor = Color.Red;
            btnAnular.BackColor = Color.WhiteSmoke;
        }

        private void btnImprimir_MouseEnter(object sender, EventArgs e)
        {
            btnImprimir.ForeColor = Color.WhiteSmoke;
            btnImprimir.BackColor = Color.FromArgb(26, 138, 94);
        }

        private void btnImprimir_MouseLeave(object sender, EventArgs e)
        {
            btnImprimir.ForeColor = Color.FromArgb(26, 138, 94);
            btnImprimir.BackColor = Color.WhiteSmoke;
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            txtCodigo.ForeColor = SystemColors.WindowText;
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            txtCodigo.ForeColor = Color.FromArgb(149, 156, 146);

        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            txtNombre.ForeColor = SystemColors.WindowText;
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            txtCodigo.ForeColor = Color.FromArgb(149, 156, 146);
        }

        private void listar()
        {
            im.listarInventario(dgvProducto);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != string.Empty && txtCodigo.Text == string.Empty)
            {
                vm.BusquedaInventarioNombre(txtNombre.Text, dgvProducto);
            }
            else if (txtCodigo.Text == string.Empty && txtNombre.Text == string.Empty)
            {
                listar();
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != string.Empty && txtNombre.Text == string.Empty)
            {
                vm.BusquedaInventarioCodigo(txtCodigo.Text, dgvProducto);
            }
            else if (txtCodigo.Text == string.Empty && txtNombre.Text == string.Empty)
            {
                listar();
            }
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            if (dgvProducto.SelectedCells.Count == 0)
            {
                MessageBox.Show("No tiene ningun producto seleccionado! seleccione un producto e intentelo nuevamente");
            }
            else
            {
                int indiceSeleccionado = dgvProducto.SelectedCells[0].RowIndex;
                DataGridViewCell cell = dgvProducto.Rows[indiceSeleccionado].Cells["Id_Inv"];
                if (cell.Value != null && cell.Value != DBNull.Value)
                {
                    DataGridViewRow selectedRow = dgvProducto.Rows[indiceSeleccionado];
                    object idInventario = selectedRow.Cells["Id_Inv"].Value;
                    object nombreProducto = selectedRow.Cells["Nombre_del_producto"].Value;
                    object precioProducto = selectedRow.Cells["Precio_del_producto"].Value;
                    object existenciasProducto = selectedRow.Cells["Existencias_del_producto"].Value;

                    if (idInventario != null && idInventario != DBNull.Value &&
                    precioProducto != null && precioProducto != DBNull.Value)
                    {
                        double precio = (double)precioProducto;
                        if (int.Parse(nupCantidad.Value.ToString()) <= int.Parse(existenciasProducto.ToString()))
                        {
                            // Agregar nueva fila al dgvCarrito
                            dgvCarrito.Rows.Add(idInventario, nombreProducto, precio, nupCantidad.Value, (double)nupCantidad.Value * precio);
                            Total = (double)nupCantidad.Value * precio;
                            txtTotal.Text = Total.ToString();
                        }
                        else
                        {
                            MessageBox.Show("No hay suficientes existencias");
                        }

                    }
                    else
                    {
                        MessageBox.Show("No tiene ningún producto seleccionado. Seleccione un producto e inténtelo nuevamente.");
                    }
                }

            }
        }

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {

            if (dgvCarrito.SelectedCells.Count == 0)
            {
                MessageBox.Show("No tiene ninguna fila seleccionada en el carrito. Seleccione una fila e inténtelo nuevamente.");
            }
            else
            {
                int indiceSeleccionado = dgvCarrito.SelectedCells[0].RowIndex;

                if (indiceSeleccionado >= 0 && indiceSeleccionado < dgvCarrito.Rows.Count)
                {
                    DataGridViewRow selectedRow = dgvCarrito.Rows[indiceSeleccionado];

                    // Verificar si la fila es nueva
                    if (!selectedRow.IsNewRow)
                    {
                        dgvCarrito.Rows.Remove(selectedRow);
                    }
                    else
                    {
                        MessageBox.Show("No se puede eliminar una fila nueva sin confirmar.");
                    }
                }
                else
                {
                    MessageBox.Show("El índice seleccionado está fuera de rango. Seleccione una fila e inténtelo nuevamente.");
                }
            }
        }
    }
}
