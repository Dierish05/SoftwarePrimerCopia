using ProyectoCursoSoftware.Formularios;
using ProyectoCursoSoftware.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCursoSoftware
{
    public partial class MenuAdministrador : Form
    {
        Conexion con;
        int n;
        public MenuAdministrador(Conexion con)
        {
            this.con = con;
            InitializeComponent();
        }

        private void AbrirFormhijo(object formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);


            }
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FormVendedor(con));
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FormProducto(con));
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FormCompras(con));
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FormProveedor(con));
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FormVenta(con));
        }

        private void reporteVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = 1;
            AbrirFormhijo(new FrmReporte(con, n));
        }

        private void reporteComrpaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = 2;
            AbrirFormhijo(new FrmReporte(con, n));
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
