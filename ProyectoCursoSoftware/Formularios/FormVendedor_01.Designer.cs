namespace ProyectoCursoSoftware.Formularios
{
    partial class FormVendedor_01
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
            label1 = new Label();
            txtPrimerNombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnGuardar = new Button();
            btnRegresar = new Button();
            txtSegundoNombre = new TextBox();
            txtPrimerApellido = new TextBox();
            txtSegundoApellido = new TextBox();
            label9 = new Label();
            label11 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            rbtnMasculino = new RadioButton();
            rbtnFemenino = new RadioButton();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtCedula = new TextBox();
            cmbMunicipio = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, -3);
            label1.Name = "label1";
            label1.Size = new Size(372, 31);
            label1.TabIndex = 9;
            label1.Text = "REGISTRO / ACTUALIZACION";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.BackColor = Color.FromArgb(221, 233, 218);
            txtPrimerNombre.BorderStyle = BorderStyle.FixedSingle;
            txtPrimerNombre.Location = new Point(145, 38);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(214, 27);
            txtPrimerNombre.TabIndex = 10;
            txtPrimerNombre.KeyDown += txtNombres_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 45);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 11;
            label2.Text = "Primer Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 79);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 12;
            label3.Text = "Segundo Nombre:";
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.FromArgb(26, 138, 94);
            btnGuardar.Location = new Point(55, 456);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(119, 41);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.ForeColor = Color.FromArgb(26, 138, 94);
            btnRegresar.Location = new Point(194, 456);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(119, 41);
            btnRegresar.TabIndex = 21;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.BackColor = Color.FromArgb(221, 233, 218);
            txtSegundoNombre.BorderStyle = BorderStyle.FixedSingle;
            txtSegundoNombre.Location = new Point(145, 71);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(214, 27);
            txtSegundoNombre.TabIndex = 24;
            txtSegundoNombre.KeyDown += txtApellidos_KeyDown;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.BackColor = Color.FromArgb(221, 233, 218);
            txtPrimerApellido.BorderStyle = BorderStyle.FixedSingle;
            txtPrimerApellido.Location = new Point(145, 106);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(214, 27);
            txtPrimerApellido.TabIndex = 31;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.BackColor = Color.FromArgb(221, 233, 218);
            txtSegundoApellido.BorderStyle = BorderStyle.FixedSingle;
            txtSegundoApellido.Location = new Point(146, 142);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(214, 27);
            txtSegundoApellido.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 150);
            label9.Name = "label9";
            label9.Size = new Size(132, 20);
            label9.TabIndex = 34;
            label9.Text = "Segundo Apellido:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 114);
            label11.Name = "label11";
            label11.Size = new Size(116, 20);
            label11.TabIndex = 33;
            label11.Text = "Primer Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 250);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 13;
            label4.Text = "Direccion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 286);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 14;
            label5.Text = "Telefono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 319);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 15;
            label6.Text = "Municipio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 349);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 16;
            label7.Text = "Email:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 384);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 17;
            label8.Text = "Cedula:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 415);
            label10.Name = "label10";
            label10.Size = new Size(44, 20);
            label10.TabIndex = 19;
            label10.Text = "Sexo:";
            // 
            // rbtnMasculino
            // 
            rbtnMasculino.AutoSize = true;
            rbtnMasculino.Location = new Point(143, 411);
            rbtnMasculino.Name = "rbtnMasculino";
            rbtnMasculino.Size = new Size(97, 24);
            rbtnMasculino.TabIndex = 22;
            rbtnMasculino.TabStop = true;
            rbtnMasculino.Text = "Masculino";
            rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFemenino
            // 
            rbtnFemenino.AutoSize = true;
            rbtnFemenino.Location = new Point(263, 411);
            rbtnFemenino.Name = "rbtnFemenino";
            rbtnFemenino.Size = new Size(95, 24);
            rbtnFemenino.TabIndex = 23;
            rbtnFemenino.TabStop = true;
            rbtnFemenino.Text = "Femenino";
            rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.FromArgb(221, 233, 218);
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.Location = new Point(146, 243);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(214, 27);
            txtDireccion.TabIndex = 25;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(221, 233, 218);
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Location = new Point(146, 279);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(214, 27);
            txtTelefono.TabIndex = 26;
            txtTelefono.KeyDown += txtTelefono_KeyDown;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(221, 233, 218);
            txtEmail.Location = new Point(146, 342);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(214, 27);
            txtEmail.TabIndex = 27;
            // 
            // txtCedula
            // 
            txtCedula.BackColor = Color.FromArgb(221, 233, 218);
            txtCedula.Location = new Point(146, 377);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(214, 27);
            txtCedula.TabIndex = 28;
            txtCedula.KeyDown += txtCedula_KeyDown;
            // 
            // cmbMunicipio
            // 
            cmbMunicipio.BackColor = Color.FromArgb(221, 233, 218);
            cmbMunicipio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMunicipio.FormattingEnabled = true;
            cmbMunicipio.Items.AddRange(new object[] { "Managua", "Esteli", "Leon", "Granada", "Masaya" });
            cmbMunicipio.Location = new Point(146, 311);
            cmbMunicipio.Name = "cmbMunicipio";
            cmbMunicipio.Size = new Size(214, 28);
            cmbMunicipio.TabIndex = 30;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 184);
            label12.Name = "label12";
            label12.Size = new Size(62, 20);
            label12.TabIndex = 35;
            label12.Text = "Usuario:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(9, 217);
            label13.Name = "label13";
            label13.Size = new Size(86, 20);
            label13.TabIndex = 36;
            label13.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(221, 233, 218);
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Location = new Point(146, 177);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(214, 27);
            txtUsuario.TabIndex = 37;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(221, 233, 218);
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.Location = new Point(146, 210);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(214, 27);
            txtContraseña.TabIndex = 38;
            // 
            // FormVendedor_01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(371, 509);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(txtSegundoApellido);
            Controls.Add(txtPrimerApellido);
            Controls.Add(cmbMunicipio);
            Controls.Add(txtCedula);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtSegundoNombre);
            Controls.Add(rbtnFemenino);
            Controls.Add(rbtnMasculino);
            Controls.Add(btnRegresar);
            Controls.Add(btnGuardar);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPrimerNombre);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVendedor_01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "x";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnGuardar;
        private Button btnRegresar;
        private Label label9;
        private Label label11;
        public TextBox txtPrimerApellido;
        public TextBox txtSegundoApellido;
        public TextBox txtPrimerNombre;
        public TextBox txtSegundoNombre;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        public RadioButton rbtnMasculino;
        public RadioButton rbtnFemenino;
        public TextBox txtDireccion;
        public TextBox txtTelefono;
        public TextBox txtEmail;
        public TextBox txtCedula;
        public ComboBox cmbMunicipio;
        private Label label12;
        private Label label13;
        public TextBox txtUsuario;
        public TextBox txtContraseña;
    }
}