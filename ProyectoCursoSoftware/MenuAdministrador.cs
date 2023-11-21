﻿using ProyectoCursoSoftware.Formularios;
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
            AbrirFormhijo(new FormVendedor());
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FormProducto());
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FormCompras());
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FormProveedor());
        }
    }
}