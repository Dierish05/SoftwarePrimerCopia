﻿namespace ProyectoCursoSoftware.Formularios
{
    partial class FormCompras_01
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
            txtProducto = new TextBox();
            btnRegresar = new Button();
            btnGuardar = new Button();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            nudPrecio = new NumericUpDown();
            nUpdownCantidad = new NumericUpDown();
            btnSeleccionar = new Button();
            nUpdownPorcentaje = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUpdownCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUpdownPorcentaje).BeginInit();
            SuspendLayout();
            // 
            // txtProducto
            // 
            txtProducto.BackColor = Color.FromArgb(221, 233, 218);
            txtProducto.BorderStyle = BorderStyle.FixedSingle;
            txtProducto.Enabled = false;
            txtProducto.Location = new Point(138, 36);
            txtProducto.Margin = new Padding(3, 2, 3, 2);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(89, 23);
            txtProducto.TabIndex = 1;
            txtProducto.KeyDown += txtCodProducto_KeyDown;
            // 
            // btnRegresar
            // 
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.ForeColor = Color.FromArgb(26, 138, 94);
            btnRegresar.Location = new Point(171, 269);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(104, 31);
            btnRegresar.TabIndex = 6;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.Control;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.FromArgb(26, 138, 94);
            btnGuardar.Location = new Point(55, 269);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(104, 31);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 98);
            label7.Name = "label7";
            label7.Size = new Size(117, 15);
            label7.TabIndex = 38;
            label7.Text = "Cantidad Comprada:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 71);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 36;
            label5.Text = "Precio Compra:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 44);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 35;
            label4.Text = "Producto:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, -2);
            label1.Name = "label1";
            label1.Size = new Size(341, 23);
            label1.TabIndex = 31;
            label1.Text = "REGISTRO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudPrecio
            // 
            nudPrecio.BackColor = Color.FromArgb(221, 233, 218);
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudPrecio.Location = new Point(138, 65);
            nudPrecio.Maximum = new decimal(new int[] { 30000, 0, 0, 0 });
            nudPrecio.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(192, 23);
            nudPrecio.TabIndex = 3;
            nudPrecio.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudPrecio.KeyDown += numericUpDown1_KeyDown;
            // 
            // nUpdownCantidad
            // 
            nUpdownCantidad.BackColor = Color.FromArgb(221, 233, 218);
            nUpdownCantidad.BorderStyle = BorderStyle.FixedSingle;
            nUpdownCantidad.Location = new Point(138, 94);
            nUpdownCantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nUpdownCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nUpdownCantidad.Name = "nUpdownCantidad";
            nUpdownCantidad.Size = new Size(192, 23);
            nUpdownCantidad.TabIndex = 4;
            nUpdownCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.FlatStyle = FlatStyle.Flat;
            btnSeleccionar.ForeColor = Color.FromArgb(26, 138, 94);
            btnSeleccionar.Location = new Point(237, 36);
            btnSeleccionar.Margin = new Padding(3, 2, 3, 2);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(94, 22);
            btnSeleccionar.TabIndex = 2;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // nUpdownPorcentaje
            // 
            nUpdownPorcentaje.BackColor = Color.FromArgb(221, 233, 218);
            nUpdownPorcentaje.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nUpdownPorcentaje.Location = new Point(149, 134);
            nUpdownPorcentaje.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nUpdownPorcentaje.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            nUpdownPorcentaje.Name = "nUpdownPorcentaje";
            nUpdownPorcentaje.Size = new Size(145, 23);
            nUpdownPorcentaje.TabIndex = 39;
            nUpdownPorcentaje.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 140);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 40;
            label2.Text = "Porcentaje de Ganancia:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 140);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 41;
            label3.Text = "%";
            // 
            // FormCompras_01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(341, 320);
            Controls.Add(label3);
            Controls.Add(nUpdownPorcentaje);
            Controls.Add(label2);
            Controls.Add(btnSeleccionar);
            Controls.Add(nUpdownCantidad);
            Controls.Add(nudPrecio);
            Controls.Add(txtProducto);
            Controls.Add(btnRegresar);
            Controls.Add(btnGuardar);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCompras_01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCompras_01";
            Load += FormCompras_01_Load;
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUpdownCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUpdownPorcentaje).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRegresar;
        private Button btnGuardar;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label1;
        public TextBox txtProducto;
        public NumericUpDown nudPrecio;
        public NumericUpDown nUpdownCantidad;
        private Button btnSeleccionar;
        public NumericUpDown nUpdownPorcentaje;
        private Label label2;
        private Label label3;
    }
}