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
            txtNombres = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            btnGuardar = new Button();
            btnRegresar = new Button();
            rbtnMasculino = new RadioButton();
            rbtnFemenino = new RadioButton();
            txtApellidos = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtCedula = new TextBox();
            cmbMunicipio = new ComboBox();
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
            label1.Size = new Size(323, 31);
            label1.TabIndex = 9;
            label1.Text = "REGISTRO / ACTUALIZACION";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(96, 39);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(214, 27);
            txtNombres.TabIndex = 10;
            txtNombres.KeyDown += txtNombres_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 45);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 11;
            label2.Text = "Nombres:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 85);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 12;
            label3.Text = "Apellidos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 124);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 13;
            label4.Text = "Direccion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 160);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 14;
            label5.Text = "Telefono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 193);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 15;
            label6.Text = "Municipio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 223);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 16;
            label7.Text = "Email:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 257);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 17;
            label8.Text = "Cedula:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 301);
            label10.Name = "label10";
            label10.Size = new Size(44, 20);
            label10.TabIndex = 19;
            label10.Text = "Sexo:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(30, 371);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(119, 41);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(169, 371);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(119, 41);
            btnRegresar.TabIndex = 21;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            rbtnMasculino.AutoSize = true;
            rbtnMasculino.Location = new Point(93, 301);
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
            rbtnFemenino.Location = new Point(213, 301);
            rbtnFemenino.Name = "rbtnFemenino";
            rbtnFemenino.Size = new Size(95, 24);
            rbtnFemenino.TabIndex = 23;
            rbtnFemenino.TabStop = true;
            rbtnFemenino.Text = "Femenino";
            rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(96, 77);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(214, 27);
            txtApellidos.TabIndex = 24;
            txtApellidos.KeyDown += txtApellidos_KeyDown;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(93, 117);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(214, 27);
            txtDireccion.TabIndex = 25;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(93, 153);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(214, 27);
            txtTelefono.TabIndex = 26;
            txtTelefono.KeyDown += txtTelefono_KeyDown;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(93, 216);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(214, 27);
            txtEmail.TabIndex = 27;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(93, 251);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(214, 27);
            txtCedula.TabIndex = 28;
            txtCedula.KeyDown += txtCedula_KeyDown;
            // 
            // cmbMunicipio
            // 
            cmbMunicipio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMunicipio.FormattingEnabled = true;
            cmbMunicipio.Items.AddRange(new object[] { "Managua", "Esteli", "Leon", "Granada", "Masaya" });
            cmbMunicipio.Location = new Point(93, 185);
            cmbMunicipio.Name = "cmbMunicipio";
            cmbMunicipio.Size = new Size(214, 28);
            cmbMunicipio.TabIndex = 30;
            // 
            // FormVendedor_01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 427);
            Controls.Add(cmbMunicipio);
            Controls.Add(txtCedula);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellidos);
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
            Controls.Add(txtNombres);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVendedor_01";
            Text = "x";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombres;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private Button btnGuardar;
        private Button btnRegresar;
        private RadioButton rbtnMasculino;
        private RadioButton rbtnFemenino;
        private TextBox txtApellidos;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtCedula;
        private ComboBox cmbMunicipio;
    }
}