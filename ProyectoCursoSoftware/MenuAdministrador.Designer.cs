namespace ProyectoCursoSoftware
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
            PanelContenedor = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Teal;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, reportesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1015, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vendedorToolStripMenuItem, productoToolStripMenuItem, compraToolStripMenuItem, proveedorToolStripMenuItem });
            inicioToolStripMenuItem.ForeColor = Color.White;
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(48, 20);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // vendedorToolStripMenuItem
            // 
            vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            vendedorToolStripMenuItem.Size = new Size(128, 22);
            vendedorToolStripMenuItem.Text = "Vendedor";
            vendedorToolStripMenuItem.Click += vendedorToolStripMenuItem_Click;
            // 
            // productoToolStripMenuItem
            // 
            productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            productoToolStripMenuItem.Size = new Size(128, 22);
            productoToolStripMenuItem.Text = "Producto";
            productoToolStripMenuItem.Click += productoToolStripMenuItem_Click;
            // 
            // compraToolStripMenuItem
            // 
            compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            compraToolStripMenuItem.Size = new Size(128, 22);
            compraToolStripMenuItem.Text = "Compra";
            compraToolStripMenuItem.Click += compraToolStripMenuItem_Click;
            // 
            // proveedorToolStripMenuItem
            // 
            proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            proveedorToolStripMenuItem.Size = new Size(128, 22);
            proveedorToolStripMenuItem.Text = "Proveedor";
            proveedorToolStripMenuItem.Click += proveedorToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.ForeColor = Color.White;
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(65, 20);
            reportesToolStripMenuItem.Text = "Reportes";
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
    }
}