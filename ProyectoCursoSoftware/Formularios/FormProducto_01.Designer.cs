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
            cmbCategoria = new ComboBox();
            this.txtDescripcion = new TextBox();
            this.txtNombre = new TextBox();
            btnRegresar = new Button();
            btnGuardar = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtCodigo = new TextBox();
            label1 = new Label();
            cmbProveedor = new ComboBox();
            SuspendLayout();
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(93, 195);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(214, 28);
            cmbCategoria.TabIndex = 52;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new Point(93, 118);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new Size(214, 27);
            this.txtDescripcion.TabIndex = 47;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new Point(96, 79);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new Size(214, 27);
            this.txtNombre.TabIndex = 46;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(179, 371);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 43;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(42, 371);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 42;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 203);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 37;
            label6.Text = "Categoria:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 161);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 36;
            label5.Text = "Proveedor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 125);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 35;
            label4.Text = "Descripcion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 34;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 33;
            label2.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(96, 40);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(214, 27);
            txtCodigo.TabIndex = 32;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, -1);
            label1.Name = "label1";
            label1.Size = new Size(323, 31);
            label1.TabIndex = 31;
            label1.Text = "REGISTRO / ACTUALIZACION";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbProveedor
            // 
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(93, 153);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(214, 28);
            cmbProveedor.TabIndex = 53;
            // 
            // FormProducto_01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 426);
            Controls.Add(cmbProveedor);
            Controls.Add(cmbCategoria);
            Controls.Add(this.txtDescripcion);
            Controls.Add(this.txtNombre);
            Controls.Add(btnRegresar);
            Controls.Add(btnGuardar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Name = "FormProducto_01";
            Text = "FormProducto_01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCategoria;
        private TextBox txtEstado;
        private TextBox txtCedula;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtApellidos;
        private RadioButton rbtnFemenino;
        private RadioButton rbtnMasculino;
        private Button btnRegresar;
        private Button btnGuardar;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtCodigo;
        private Label label1;
        private ComboBox cmbProveedor;
    }
}