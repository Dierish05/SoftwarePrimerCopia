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
            txtProveedor = new TextBox();
            btnSeleccionar = new Button();
            SuspendLayout();
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.FromArgb(221, 233, 218);
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(93, 195);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(214, 28);
            cmbCategoria.TabIndex = 78;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.FromArgb(221, 233, 218);
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Location = new Point(93, 117);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(214, 27);
            txtDescripcion.TabIndex = 77;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(221, 233, 218);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(96, 77);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(214, 27);
            txtNombre.TabIndex = 76;
            txtNombre.KeyDown += txtNombre_KeyDown;
            // 
            // btnRegresar
            // 
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.ForeColor = Color.FromArgb(26, 138, 94);
            btnRegresar.Location = new Point(173, 371);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(119, 41);
            btnRegresar.TabIndex = 75;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.FromArgb(26, 138, 94);
            btnGuardar.Location = new Point(35, 371);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(119, 41);
            btnGuardar.TabIndex = 74;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 203);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 73;
            label6.Text = "Categoria:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 160);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 72;
            label5.Text = "Proveedor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 124);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 71;
            label4.Text = "Descripcion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 85);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 70;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 45);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 69;
            label2.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(221, 233, 218);
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Location = new Point(96, 39);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(214, 27);
            txtCodigo.TabIndex = 68;
            txtCodigo.KeyDown += txtCodigo_KeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, -3);
            label1.Name = "label1";
            label1.Size = new Size(323, 31);
            label1.TabIndex = 67;
            label1.Text = "REGISTRO / ACTUALIZACION";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(93, 162);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.ReadOnly = true;
            txtProveedor.Size = new Size(101, 27);
            txtProveedor.TabIndex = 79;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.FlatStyle = FlatStyle.Flat;
            btnSeleccionar.ForeColor = Color.FromArgb(26, 138, 94);
            btnSeleccionar.Location = new Point(200, 160);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(107, 29);
            btnSeleccionar.TabIndex = 80;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // FormProducto_01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(322, 427);
            Controls.Add(btnSeleccionar);
            Controls.Add(txtProveedor);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProducto_01";
            Text = "FormProducto_01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private TextBox txtProveedor;
        private Button btnSeleccionar;
    }
}