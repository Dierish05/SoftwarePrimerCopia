namespace ProyectoCursoSoftware.Formularios
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
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            txtCodProducto = new TextBox();
            btnRegresar = new Button();
            btnGuardar = new Button();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            dtpFechaCompra = new DateTimePicker();
            SuspendLayout();
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(159, 189);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(214, 27);
            txtCantidad.TabIndex = 49;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(159, 153);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(214, 27);
            txtPrecio.TabIndex = 48;
            // 
            // txtCodProducto
            // 
            txtCodProducto.Location = new Point(159, 117);
            txtCodProducto.Name = "txtCodProducto";
            txtCodProducto.Size = new Size(214, 27);
            txtCodProducto.TabIndex = 47;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(250, 370);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 43;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(46, 370);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 42;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 196);
            label7.Name = "label7";
            label7.Size = new Size(146, 20);
            label7.TabIndex = 38;
            label7.Text = "Cantidad Comprada:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 160);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 36;
            label5.Text = "Precio Compra:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 124);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 35;
            label4.Text = "Cod Producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 85);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 34;
            label3.Text = "Fecha Compra:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 46);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 33;
            label2.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(162, 39);
            txtId.Name = "txtId";
            txtId.Size = new Size(214, 27);
            txtId.TabIndex = 32;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1, -2);
            label1.Name = "label1";
            label1.Size = new Size(394, 31);
            label1.TabIndex = 31;
            label1.Text = "REGISTRO / ACTUALIZACION";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpFechaCompra
            // 
            dtpFechaCompra.Location = new Point(159, 78);
            dtpFechaCompra.Name = "dtpFechaCompra";
            dtpFechaCompra.Size = new Size(217, 27);
            dtpFechaCompra.TabIndex = 50;
            // 
            // FormCompras_01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 426);
            Controls.Add(dtpFechaCompra);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtCodProducto);
            Controls.Add(btnRegresar);
            Controls.Add(btnGuardar);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "FormCompras_01";
            Text = "FormCompras_01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private TextBox txtCodProducto;
        private Button btnRegresar;
        private Button btnGuardar;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private DateTimePicker dtpFechaCompra;
    }
}