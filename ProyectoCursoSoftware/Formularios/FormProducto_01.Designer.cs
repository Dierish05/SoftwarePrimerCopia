namespace ProyectoCursoSoftware.Formularios
{
    partial class FormProducto_01
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
            cmbProveedor = new ComboBox();
            cmbCategoria = new ComboBox();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            btnRegresar = new Button();
            btnGuardar = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtCodigo = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbProveedor
            // 
            cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(81, 114);
            cmbProveedor.Margin = new Padding(3, 2, 3, 2);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(188, 23);
            cmbProveedor.TabIndex = 79;
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(81, 146);
            cmbCategoria.Margin = new Padding(3, 2, 3, 2);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(188, 23);
            cmbCategoria.TabIndex = 78;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(81, 88);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(188, 23);
            txtDescripcion.TabIndex = 77;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(84, 58);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(188, 23);
            txtNombre.TabIndex = 76;
            txtNombre.KeyDown += txtNombre_KeyDown;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(157, 278);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(82, 22);
            btnRegresar.TabIndex = 75;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(37, 278);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 22);
            btnGuardar.TabIndex = 74;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 152);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 73;
            label6.Text = "Categoria:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 120);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 72;
            label5.Text = "Proveedor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 93);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 71;
            label4.Text = "Descripcion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 64);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 70;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 34);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 69;
            label2.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(84, 29);
            txtCodigo.Margin = new Padding(3, 2, 3, 2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(188, 23);
            txtCodigo.TabIndex = 68;
            txtCodigo.KeyDown += txtCodigo_KeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, -2);
            label1.Name = "label1";
            label1.Size = new Size(283, 23);
            label1.TabIndex = 67;
            label1.Text = "REGISTRO / ACTUALIZACION";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormProducto_01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 320);
            Controls.Add(cmbProveedor);
            Controls.Add(cmbCategoria);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(btnRegresar);
            Controls.Add(btnGuardar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormProducto_01";
            Text = "FormProducto_01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProveedor;
        private ComboBox cmbCategoria;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Button btnRegresar;
        private Button btnGuardar;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtCodigo;
        private Label label1;
    }
}