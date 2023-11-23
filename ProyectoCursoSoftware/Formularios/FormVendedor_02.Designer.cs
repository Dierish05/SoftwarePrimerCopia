namespace ProyectoCursoSoftware.Formularios
{
    partial class FormVendedor_02
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
            txtId = new TextBox();
            label11 = new Label();
            txtPrimerApellido = new TextBox();
            cmbMunicipio = new ComboBox();
            txtCedula = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            rbtnFemenino = new RadioButton();
            rbtnMasculino = new RadioButton();
            btnRegresar = new Button();
            btnActualizar = new Button();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            txtPrimerNombre = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(11, 333);
            txtId.Name = "txtId";
            txtId.Size = new Size(34, 27);
            txtId.TabIndex = 66;
            txtId.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(8, 91);
            label11.Name = "label11";
            label11.Size = new Size(75, 20);
            label11.TabIndex = 62;
            label11.Text = "Apellidos:";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.BackColor = Color.FromArgb(221, 233, 218);
            txtPrimerApellido.BorderStyle = BorderStyle.FixedSingle;
            txtPrimerApellido.Enabled = false;
            txtPrimerApellido.Location = new Point(144, 83);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(214, 27);
            txtPrimerApellido.TabIndex = 40;
            // 
            // cmbMunicipio
            // 
            cmbMunicipio.BackColor = Color.FromArgb(221, 233, 218);
            cmbMunicipio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMunicipio.FormattingEnabled = true;
            cmbMunicipio.Items.AddRange(new object[] { "Managua", "Esteli", "Leon", "Granada", "Masaya" });
            cmbMunicipio.Location = new Point(145, 192);
            cmbMunicipio.Name = "cmbMunicipio";
            cmbMunicipio.Size = new Size(214, 28);
            cmbMunicipio.TabIndex = 46;
            // 
            // txtCedula
            // 
            txtCedula.BackColor = Color.FromArgb(221, 233, 218);
            txtCedula.Enabled = false;
            txtCedula.Location = new Point(145, 258);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(214, 27);
            txtCedula.TabIndex = 49;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(221, 233, 218);
            txtEmail.Location = new Point(145, 223);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(214, 27);
            txtEmail.TabIndex = 48;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(221, 233, 218);
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Location = new Point(145, 160);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(214, 27);
            txtTelefono.TabIndex = 45;
            txtTelefono.KeyDown += txtTelefono_KeyDown;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.FromArgb(221, 233, 218);
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.Location = new Point(145, 124);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(214, 27);
            txtDireccion.TabIndex = 44;
            // 
            // rbtnFemenino
            // 
            rbtnFemenino.AutoSize = true;
            rbtnFemenino.Enabled = false;
            rbtnFemenino.Location = new Point(262, 292);
            rbtnFemenino.Name = "rbtnFemenino";
            rbtnFemenino.Size = new Size(95, 24);
            rbtnFemenino.TabIndex = 54;
            rbtnFemenino.TabStop = true;
            rbtnFemenino.Text = "Femenino";
            rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            rbtnMasculino.AutoSize = true;
            rbtnMasculino.Enabled = false;
            rbtnMasculino.Location = new Point(142, 292);
            rbtnMasculino.Name = "rbtnMasculino";
            rbtnMasculino.Size = new Size(97, 24);
            rbtnMasculino.TabIndex = 52;
            rbtnMasculino.TabStop = true;
            rbtnMasculino.Text = "Masculino";
            rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.ForeColor = Color.FromArgb(26, 138, 94);
            btnRegresar.Location = new Point(193, 459);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(119, 41);
            btnRegresar.TabIndex = 57;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = Color.FromArgb(26, 138, 94);
            btnActualizar.Location = new Point(54, 459);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(119, 41);
            btnActualizar.TabIndex = 55;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 296);
            label10.Name = "label10";
            label10.Size = new Size(44, 20);
            label10.TabIndex = 61;
            label10.Text = "Sexo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 265);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 60;
            label8.Text = "Cedula:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 230);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 59;
            label7.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 200);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 58;
            label6.Text = "Municipio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 167);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 56;
            label5.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 131);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 53;
            label4.Text = "Direccion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 48);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 50;
            label2.Text = "Nombres:";
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.BackColor = Color.FromArgb(221, 233, 218);
            txtPrimerNombre.BorderStyle = BorderStyle.FixedSingle;
            txtPrimerNombre.Enabled = false;
            txtPrimerNombre.Location = new Point(144, 41);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(214, 27);
            txtPrimerNombre.TabIndex = 38;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(-1, 0);
            label1.Name = "label1";
            label1.Size = new Size(390, 31);
            label1.TabIndex = 47;
            label1.Text = "REGISTRO / ACTUALIZACION";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormVendedor_02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 509);
            Controls.Add(txtId);
            Controls.Add(label11);
            Controls.Add(txtPrimerApellido);
            Controls.Add(cmbMunicipio);
            Controls.Add(txtCedula);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(rbtnFemenino);
            Controls.Add(rbtnMasculino);
            Controls.Add(btnRegresar);
            Controls.Add(btnActualizar);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtPrimerNombre);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVendedor_02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormVendedor_02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txtId;
        private Label label11;
        public TextBox txtPrimerApellido;
        public ComboBox cmbMunicipio;
        public TextBox txtCedula;
        public TextBox txtEmail;
        public TextBox txtTelefono;
        public TextBox txtDireccion;
        public RadioButton rbtnFemenino;
        public RadioButton rbtnMasculino;
        private Button btnRegresar;
        private Button btnActualizar;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        public TextBox txtPrimerNombre;
        private Label label1;
    }
}