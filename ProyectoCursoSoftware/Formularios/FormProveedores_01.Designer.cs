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
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(169, 371);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(119, 41);
            btnRegresar.TabIndex = 43;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
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
            // FormProveedores_01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 427);
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

        private ComboBox cmbMunicipio;
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
        private TextBox txtNombre;
        private Label label1;
    }
}