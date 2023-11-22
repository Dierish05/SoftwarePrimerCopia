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
        public FormVenta(Conexion Con)
        {
            this.con = Con;
            im = new InventarioModel(con);
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
    }
}
