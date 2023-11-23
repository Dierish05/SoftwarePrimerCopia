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
        private VendedorModel vd;
        private double Total;
        public double subtotal;
        private string usuario;
        public FormVenta(Conexion Con, string Usuario)
        {
            this.con = Con;
            this.usuario = Usuario;
            im = new InventarioModel(con);
            vm = new VentaModel(con);
            vd = new VendedorModel(con);
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
        int numeroDeDecimales = 2;
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
                        if (int.Parse(txtCantidad.Text) <= int.Parse(existenciasProducto.ToString()) && int.Parse(txtCantidad.Text) != 0)
                        {
                            double subtotalfix = int.Parse(txtCantidad.Text) * precio;
                            subtotalfix = Math.Round(subtotalfix, numeroDeDecimales);
                            int cantidad = int.Parse(txtCantidad.Text);
                            // Agregar nueva fila al dgvCarrito
                            dgvCarrito.Rows.Add(idInventario, nombreProducto, precio, int.Parse(txtCantidad.Text), subtotalfix);
                            vm.RestarVenta(int.Parse(idInventario.ToString()), cantidad);
                            Total = cantidad * precio;
                            Total = Math.Round(Total, numeroDeDecimales);
                            txtTotal.Text = Total.ToString();
                            listar();
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
                        subtotal = (double)dgvCarrito.Rows[indiceSeleccionado].Cells["Subtotal"].Value;
                        int Idd = int.Parse(dgvCarrito.Rows[indiceSeleccionado].Cells["Id_Inventario"].Value.ToString());
                        int cantidad = int.Parse(dgvCarrito.Rows[indiceSeleccionado].Cells["Cantidad"].Value.ToString());
                        vm.SumarVenta(Idd, cantidad);
                        listar();
                        subtotal = Math.Round(subtotal, numeroDeDecimales);
                        dgvCarrito.Rows.Remove(selectedRow);
                        Total = Total - subtotal;
                        txtTotal.Text = Total.ToString();
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

        public List<int> obtenerIdS()
        {
            List<int> lIdServicios = new List<int>();
            foreach (DataGridViewRow dr in dgvCarrito.Rows)
            {
                int id = Convert.ToInt32(dr.Cells["Id_Inventario"].Value);
                lIdServicios.Add(id);
            }
            return lIdServicios;
        }

        public List<int> obtenerCantidades()
        {
            List<int> lIdServicios = new List<int>();
            foreach (DataGridViewRow dr in dgvCarrito.Rows)
            {
                int id = Convert.ToInt32(dr.Cells["Cantidad"].Value);
                lIdServicios.Add(id);
            }
            return lIdServicios;
        }



        public int ObtenerIdVentaS()
        {
            dataGridView1.DataSource = null;
            vm.listarVentas(dataGridView1);
            List<int> lVentaSId = new List<int>();
            int n = 0;

            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                int id = Convert.ToInt32(dr.Cells["Id_Venta"].Value);
                lVentaSId.Add(id);
                n++;
            }
            int idd = lVentaSId[n - 2];
            return idd;
        }

        //public int ObtenerIdVendedor()
        //{
        //    dataGridView2.DataSource = null;
        //    vd.BusquedaVendedorUsuario(usuario,dataGridView1);
        //    List<int> lVentaSId = new List<int>();

        //    foreach (DataGridViewRow dr in dataGridView1.Rows)
        //    {
        //        int vSId;
        //        vSId = Convert.ToInt32(dr.Cells["Id_Vendedor"].Value);
        //        lVentaSId.Add(vSId);
        //    }
        //    int IdVentaS = (lVentaSId[lVentaSId.Count - 2]);
        //    return IdVentaS;
        //}

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //int vendedor = ObtenerIdVendedor();
            if (int.Parse(txtTotal.Text) <= int.Parse(txtMonto.Text))
            {
                vm.CrearVenta(1);
                int venta = ObtenerIdVentaS();
                List<int> datos = obtenerIdS();
                List<int> cant = obtenerCantidades();
                for (int i = 0; i < datos.Count; i++)
                {
                    vm.SumarVenta(datos[i], cant[i]);
                    vm.CrearDetVenta(venta, datos[i], cant[i]);
                }
                dgvCarrito.Rows.Clear();
                MessageBox.Show("La venta se realizo con exito");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (!((char.IsDigit((char)e.KeyValue) || e.KeyValue == (char)Keys.OemPeriod || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete) && !(e.KeyValue == (char)Keys.OemPeriod && txtCantidad.Text.Contains("."))))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtMonto_KeyDown(object sender, KeyEventArgs e)
        {
            if (!((char.IsDigit((char)e.KeyValue) || e.KeyValue == (char)Keys.OemPeriod || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete) && !(e.KeyValue == (char)Keys.OemPeriod && txtMonto.Text.Contains("."))))
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
