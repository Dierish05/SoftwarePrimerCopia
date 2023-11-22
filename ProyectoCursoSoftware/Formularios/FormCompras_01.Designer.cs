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
            txtCodProducto = new TextBox();
            btnRegresar = new Button();
            btnGuardar = new Button();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            nUpdownCantidad = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUpdownCantidad).BeginInit();
            SuspendLayout();
            // 
            // txtCodProducto
            // 
            txtCodProducto.BackColor = Color.FromArgb(221, 233, 218);
            txtCodProducto.BorderStyle = BorderStyle.FixedSingle;
            txtCodProducto.Location = new Point(160, 64);
            txtCodProducto.Name = "txtCodProducto";
            txtCodProducto.Size = new Size(137, 27);
            txtCodProducto.TabIndex = 47;
            txtCodProducto.KeyDown += txtCodProducto_KeyDown;
            // 
            // btnRegresar
            // 
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.ForeColor = Color.FromArgb(26, 138, 94);
            btnRegresar.Location = new Point(173, 359);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(119, 41);
            btnRegresar.TabIndex = 43;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.Control;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.FromArgb(26, 138, 94);
            btnGuardar.Location = new Point(41, 359);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(119, 41);
            btnGuardar.TabIndex = 42;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 147);
            label7.Name = "label7";
            label7.Size = new Size(146, 20);
            label7.TabIndex = 38;
            label7.Text = "Cantidad Comprada:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 111);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 36;
            label5.Text = "Precio Compra:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 75);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 35;
            label4.Text = "Cod Producto:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1, -3);
            label1.Name = "label1";
            label1.Size = new Size(321, 31);
            label1.TabIndex = 31;
            label1.Text = "REGISTRO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(221, 233, 218);
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDown1.Location = new Point(160, 103);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Maximum = new decimal(new int[] { 30000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(137, 27);
            numericUpDown1.TabIndex = 50;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.KeyDown += numericUpDown1_KeyDown;
            // 
            // nUpdownCantidad
            // 
            nUpdownCantidad.BackColor = Color.FromArgb(221, 233, 218);
            nUpdownCantidad.BorderStyle = BorderStyle.FixedSingle;
            nUpdownCantidad.Location = new Point(160, 141);
            nUpdownCantidad.Margin = new Padding(3, 4, 3, 4);
            nUpdownCantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nUpdownCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nUpdownCantidad.Name = "nUpdownCantidad";
            nUpdownCantidad.Size = new Size(137, 27);
            nUpdownCantidad.TabIndex = 51;
            nUpdownCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // FormCompras_01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(322, 427);
            Controls.Add(nUpdownCantidad);
            Controls.Add(numericUpDown1);
            Controls.Add(txtCodProducto);
            Controls.Add(btnRegresar);
            Controls.Add(btnGuardar);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCompras_01";
            Text = "FormCompras_01";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUpdownCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCodProducto;
        private Button btnRegresar;
        private Button btnGuardar;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown nUpdownCantidad;
    }
}