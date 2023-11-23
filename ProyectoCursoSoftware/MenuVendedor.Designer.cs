namespace ProyectoCursoSoftware
{
    partial class MenuVendedor
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
            cerrarToolStripMenuItem = new ToolStripMenuItem();
            PanelContenedor = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkSlateGray;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, cerrarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1142, 34);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            inicioToolStripMenuItem.ForeColor = Color.White;
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(68, 28);
            inicioToolStripMenuItem.Text = "Venta";
            inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
            // 
            // cerrarToolStripMenuItem
            // 
            cerrarToolStripMenuItem.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cerrarToolStripMenuItem.ForeColor = Color.White;
            cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            cerrarToolStripMenuItem.Size = new Size(72, 28);
            cerrarToolStripMenuItem.Text = "Cerrar";
            cerrarToolStripMenuItem.Click += cerrarToolStripMenuItem_Click;
            // 
            // PanelContenedor
            // 
            PanelContenedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelContenedor.Location = new Point(0, 31);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(1142, 602);
            PanelContenedor.TabIndex = 2;
            // 
            // MenuVendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 630);
            Controls.Add(PanelContenedor);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuVendedor";
            Text = "MenuVendedor";
            WindowState = FormWindowState.Maximized;
            Load += MenuVendedor_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem cerrarToolStripMenuItem;
        private Panel PanelContenedor;
    }
}