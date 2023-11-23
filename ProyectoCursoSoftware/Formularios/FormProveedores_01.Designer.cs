namespace ProyectoCursoSoftware.Formularios
{
    partial class FormProveedores_01
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
            btnRegresar = new Button();
            btnGuardar = new Button();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtDireccion = new TextBox();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.ForeColor = Color.FromArgb(26, 138, 94);
            btnRegresar.Location = new Point(169, 371);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(119, 41);
            btnRegresar.TabIndex = 43;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.FromArgb(26, 138, 94);
            btnGuardar.Location = new Point(26, 371);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(119, 41);
            btnGuardar.TabIndex = 42;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 45);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 33;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(221, 233, 218);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(94, 45);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(214, 27);
            txtNombre.TabIndex = 32;
            txtNombre.TextChanged += txtNombre_TextChanged;
            txtNombre.KeyDown += txtNombre_KeyDown;
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
            label1.TabIndex = 31;
            label1.Text = "REGISTRO / ACTUALIZACION";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 84);
            label11.Name = "label11";
            label11.Size = new Size(70, 20);
            label11.TabIndex = 45;
            label11.Text = "Telefono:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 128);
            label12.Name = "label12";
            label12.Size = new Size(49, 20);
            label12.TabIndex = 47;
            label12.Text = "Email:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 170);
            label13.Name = "label13";
            label13.Size = new Size(75, 20);
            label13.TabIndex = 49;
            label13.Text = "Dirección:";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(221, 233, 218);
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Location = new Point(94, 84);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(214, 27);
            txtTelefono.TabIndex = 50;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(221, 233, 218);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(94, 128);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(214, 27);
            txtEmail.TabIndex = 51;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.FromArgb(221, 233, 218);
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.Location = new Point(94, 170);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(214, 27);
            txtDireccion.TabIndex = 52;
            // 
            // FormProveedores_01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(322, 427);
            Controls.Add(txtDireccion);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(btnRegresar);
            Controls.Add(btnGuardar);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProveedores_01";
            Text = "FormProveedores_01";
            Load += FormProveedores_01_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Label label1;
        private Label label11;
        private Label label12;
        private Label label13;
        public TextBox txtNombre;
        public TextBox txtTelefono;
        public TextBox txtEmail;
        public TextBox txtDireccion;
    }
}