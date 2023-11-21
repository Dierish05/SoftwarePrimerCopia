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
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, -2);
            label1.Name = "label1";
            label1.Size = new Size(280, 23);
            label1.TabIndex = 9;
            label1.Text = "REGISTRO / ACTUALIZACION";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(84, 29);
            txtNombres.Margin = new Padding(3, 2, 3, 2);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(188, 23);
            txtNombres.TabIndex = 10;
            txtNombres.KeyDown += txtNombres_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 34);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 11;
            label2.Text = "Nombres:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 64);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 12;
            label3.Text = "Apellidos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 93);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 13;
            label4.Text = "Direccion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 120);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 14;
            label5.Text = "Telefono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 145);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 15;
            label6.Text = "Municipio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 167);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 16;
            label7.Text = "Email:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 193);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 17;
            label8.Text = "Cedula:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 242);
            label10.Name = "label10";
            label10.Size = new Size(35, 15);
            label10.TabIndex = 19;
            label10.Text = "Sexo:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(37, 278);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 22);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(157, 278);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(82, 22);
            btnRegresar.TabIndex = 21;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            rbtnMasculino.AutoSize = true;
            rbtnMasculino.Location = new Point(81, 242);
            rbtnMasculino.Margin = new Padding(3, 2, 3, 2);
            rbtnMasculino.Name = "rbtnMasculino";
            rbtnMasculino.Size = new Size(80, 19);
            rbtnMasculino.TabIndex = 22;
            rbtnMasculino.TabStop = true;
            rbtnMasculino.Text = "Masculino";
            rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFemenino
            // 
            rbtnFemenino.AutoSize = true;
            rbtnFemenino.Location = new Point(186, 242);
            rbtnFemenino.Margin = new Padding(3, 2, 3, 2);
            rbtnFemenino.Name = "rbtnFemenino";
            rbtnFemenino.Size = new Size(78, 19);
            rbtnFemenino.TabIndex = 23;
            rbtnFemenino.TabStop = true;
            rbtnFemenino.Text = "Femenino";
            rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(84, 58);
            txtApellidos.Margin = new Padding(3, 2, 3, 2);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(188, 23);
            txtApellidos.TabIndex = 24;
            txtApellidos.KeyDown += txtApellidos_KeyDown;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(81, 88);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(188, 23);
            txtDireccion.TabIndex = 25;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(81, 115);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(188, 23);
            txtTelefono.TabIndex = 26;
            txtTelefono.KeyDown += txtTelefono_KeyDown;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(81, 162);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(188, 23);
            txtEmail.TabIndex = 27;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(81, 188);
            txtCedula.Margin = new Padding(3, 2, 3, 2);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(188, 23);
            txtCedula.TabIndex = 28;
            txtCedula.KeyDown += txtCedula_KeyDown;
            // 
            // cmbMunicipio
            // 
            cmbMunicipio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMunicipio.FormattingEnabled = true;
            cmbMunicipio.Items.AddRange(new object[] { "Managua", "Esteli", "Leon", "Granada", "Masaya" });
            cmbMunicipio.Location = new Point(81, 139);
            cmbMunicipio.Margin = new Padding(3, 2, 3, 2);
            cmbMunicipio.Name = "cmbMunicipio";
            cmbMunicipio.Size = new Size(188, 23);
            cmbMunicipio.TabIndex = 30;
            // 
            // FormVendedor_01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 320);
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
            Margin = new Padding(3, 2, 3, 2);
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