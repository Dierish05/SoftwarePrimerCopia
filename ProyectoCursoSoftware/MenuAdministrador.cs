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
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormVendedor frmVendedor = new FormVendedor();
                frmVendedor.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is FormVendedor)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmVendedor.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormProducto frmProducto = new FormProducto();
                frmProducto.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is FormProducto)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmProducto.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormCompras frmCompras = new FormCompras();
                frmCompras.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is FormCompras)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmCompras.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormProveedor frmProveedor = new FormProveedor();
                frmProveedor.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is FormProveedor)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmProveedor.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
