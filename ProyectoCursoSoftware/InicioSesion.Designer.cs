namespace ProyectoCursoSoftware
{
    partial class InicioSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            button1 = new Button();
            btnAceptar = new Button();
            label2 = new Label();
            label3 = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            lblIntentos = new Label();
            checkBox1 = new CheckBox();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 2);
            label1.Name = "label1";
            label1.Size = new Size(660, 25);
            label1.TabIndex = 8;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(37, 42, 64);
            button1.Image = Properties.Resources.Cerrar20;
            button1.Location = new Point(595, -2);
            button1.Name = "button1";
            button1.Size = new Size(68, 29);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(69, 300);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(496, 29);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Log in";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(69, 130);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 6;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(69, 190);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 9;
            label3.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(162, 123);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(403, 27);
            txtUsuario.TabIndex = 1;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(162, 187);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(403, 27);
            txtContrasena.TabIndex = 2;
            // 
            // lblIntentos
            // 
            lblIntentos.AutoSize = true;
            lblIntentos.ForeColor = Color.Firebrick;
            lblIntentos.Location = new Point(69, 264);
            lblIntentos.Name = "lblIntentos";
            lblIntentos.Size = new Size(0, 20);
            lblIntentos.TabIndex = 7;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(83, 223);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Mostrar";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 42, 64);
            ClientSize = new Size(663, 355);
            Controls.Add(checkBox1);
            Controls.Add(lblIntentos);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAceptar);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InicioSesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button btnAceptar;
        private Label label2;
        private Label label3;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Label lblIntentos;
        private CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
    }
}