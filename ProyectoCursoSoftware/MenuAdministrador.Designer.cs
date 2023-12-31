﻿namespace ProyectoCursoSoftware
{
    partial class MenuAdministrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            vendedorToolStripMenuItem = new ToolStripMenuItem();
            productoToolStripMenuItem = new ToolStripMenuItem();
            compraToolStripMenuItem = new ToolStripMenuItem();
            proveedorToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            reporteVentaToolStripMenuItem = new ToolStripMenuItem();
            reporteComrpaToolStripMenuItem = new ToolStripMenuItem();
            reporteInventarioToolStripMenuItem = new ToolStripMenuItem();
            cerrarToolStripMenuItem = new ToolStripMenuItem();
            PanelContenedor = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkSlateGray;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, reportesToolStripMenuItem, cerrarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1015, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vendedorToolStripMenuItem, productoToolStripMenuItem, compraToolStripMenuItem, proveedorToolStripMenuItem });
            inicioToolStripMenuItem.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            inicioToolStripMenuItem.ForeColor = Color.White;
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(56, 24);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // vendedorToolStripMenuItem
            // 
            vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            vendedorToolStripMenuItem.Size = new Size(180, 24);
            vendedorToolStripMenuItem.Text = "Vendedor";
            vendedorToolStripMenuItem.Click += vendedorToolStripMenuItem_Click;
            // 
            // productoToolStripMenuItem
            // 
            productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            productoToolStripMenuItem.Size = new Size(180, 24);
            productoToolStripMenuItem.Text = "Producto";
            productoToolStripMenuItem.Click += productoToolStripMenuItem_Click;
            // 
            // compraToolStripMenuItem
            // 
            compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            compraToolStripMenuItem.Size = new Size(180, 24);
            compraToolStripMenuItem.Text = "Compra";
            compraToolStripMenuItem.Click += compraToolStripMenuItem_Click;
            // 
            // proveedorToolStripMenuItem
            // 
            proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            proveedorToolStripMenuItem.Size = new Size(180, 24);
            proveedorToolStripMenuItem.Text = "Proveedor";
            proveedorToolStripMenuItem.Click += proveedorToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reporteVentaToolStripMenuItem, reporteComrpaToolStripMenuItem, reporteInventarioToolStripMenuItem });
            reportesToolStripMenuItem.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            reportesToolStripMenuItem.ForeColor = Color.White;
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(76, 24);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteVentaToolStripMenuItem
            // 
            reporteVentaToolStripMenuItem.Name = "reporteVentaToolStripMenuItem";
            reporteVentaToolStripMenuItem.Size = new Size(192, 24);
            reporteVentaToolStripMenuItem.Text = "Reporte Venta";
            reporteVentaToolStripMenuItem.Click += reporteVentaToolStripMenuItem_Click;
            // 
            // reporteComrpaToolStripMenuItem
            // 
            reporteComrpaToolStripMenuItem.Name = "reporteComrpaToolStripMenuItem";
            reporteComrpaToolStripMenuItem.Size = new Size(192, 24);
            reporteComrpaToolStripMenuItem.Text = "Reporte Compra";
            reporteComrpaToolStripMenuItem.Click += reporteComrpaToolStripMenuItem_Click;
            // 
            // reporteInventarioToolStripMenuItem
            // 
            reporteInventarioToolStripMenuItem.Name = "reporteInventarioToolStripMenuItem";
            reporteInventarioToolStripMenuItem.Size = new Size(192, 24);
            reporteInventarioToolStripMenuItem.Text = "Reporte Inventario";
            reporteInventarioToolStripMenuItem.Click += reporteInventarioToolStripMenuItem_Click;
            // 
            // cerrarToolStripMenuItem
            // 
            cerrarToolStripMenuItem.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cerrarToolStripMenuItem.ForeColor = Color.White;
            cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            cerrarToolStripMenuItem.Size = new Size(59, 24);
            cerrarToolStripMenuItem.Text = "Cerrar";
            cerrarToolStripMenuItem.Click += cerrarToolStripMenuItem_Click;
            // 
            // PanelContenedor
            // 
            PanelContenedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelContenedor.Location = new Point(0, 23);
            PanelContenedor.Margin = new Padding(3, 2, 3, 2);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(1015, 482);
            PanelContenedor.TabIndex = 1;
            // 
            // MenuAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 508);
            Controls.Add(PanelContenedor);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuAdministrador";
            Text = "MenuAdministrador";
            WindowState = FormWindowState.Maximized;
            FormClosing += MenuAdministrador_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem vendedorToolStripMenuItem;
        private ToolStripMenuItem productoToolStripMenuItem;
        private ToolStripMenuItem compraToolStripMenuItem;
        private ToolStripMenuItem proveedorToolStripMenuItem;
        private Panel PanelContenedor;
        private ToolStripMenuItem reporteVentaToolStripMenuItem;
        private ToolStripMenuItem reporteComrpaToolStripMenuItem;
        private ToolStripMenuItem cerrarToolStripMenuItem;
        private ToolStripMenuItem reporteInventarioToolStripMenuItem;
    }
}