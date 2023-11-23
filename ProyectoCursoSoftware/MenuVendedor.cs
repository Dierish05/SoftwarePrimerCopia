using ProyectoCursoSoftware.Formularios;
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
    public partial class MenuVendedor : Form
    {
        Conexion con;
        public MenuVendedor(Conexion con)
        {
            InitializeComponent();
            this.con = con;
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

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FormVenta(con));
        }

        private void MenuVendedor_Load(object sender, EventArgs e)
        {
            AbrirFormhijo(new FormVenta(con));
        }
    }
}
