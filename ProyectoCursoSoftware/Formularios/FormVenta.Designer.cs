namespace ProyectoCursoSoftware.Formularios
{
    partial class FormVenta
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
            label2 = new Label();
            txtVendedor = new TextBox();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            nupCantidad = new NumericUpDown();
            label10 = new Label();
            btnEliminarProd = new Button();
            label9 = new Label();
            label8 = new Label();
            btnAgregarProd = new Button();
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            dgvProducto = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            dgvCarrito = new DataGridView();
            Id_Inventario = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            btnImprimir = new Button();
            btnAnular = new Button();
            btnGuardar = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtSubTotal = new TextBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(-3, 0);
            label1.Name = "label1";
            label1.Size = new Size(1144, 51);
            label1.TabIndex = 1;
            label1.Text = "VENTA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(335, 67);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Vendedor";
            // 
            // txtVendedor
            // 
            txtVendedor.BackColor = Color.FromArgb(221, 233, 218);
            txtVendedor.BorderStyle = BorderStyle.FixedSingle;
            txtVendedor.Location = new Point(22, 88);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.ReadOnly = true;
            txtVendedor.Size = new Size(386, 27);
            txtVendedor.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Location = new Point(22, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1103, 280);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Principal";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(nupCantidad);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(btnEliminarProd);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(btnAgregarProd);
            groupBox3.Controls.Add(txtNombre);
            groupBox3.Controls.Add(txtCodigo);
            groupBox3.Controls.Add(dgvProducto);
            groupBox3.Location = new Point(6, 29);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1091, 235);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Buscar Producto";
            // 
            // nupCantidad
            // 
            nupCantidad.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nupCantidad.Location = new Point(949, 110);
            nupCantidad.Name = "nupCantidad";
            nupCantidad.Size = new Size(135, 27);
            nupCantidad.TabIndex = 14;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(1017, 87);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 24;
            label10.Text = "Cantidad";
            // 
            // btnEliminarProd
            // 
            btnEliminarProd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminarProd.FlatStyle = FlatStyle.Flat;
            btnEliminarProd.ForeColor = Color.FromArgb(26, 138, 94);
            btnEliminarProd.Location = new Point(949, 199);
            btnEliminarProd.Name = "btnEliminarProd";
            btnEliminarProd.Size = new Size(137, 29);
            btnEliminarProd.TabIndex = 4;
            btnEliminarProd.Text = "Eliminar Producto";
            btnEliminarProd.UseVisualStyleBackColor = true;
            btnEliminarProd.Click += btnEliminarProd_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(224, 21);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 23;
            label9.Text = "Nombre";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(89, 21);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 22;
            label8.Text = "Codigo";
            // 
            // btnAgregarProd
            // 
            btnAgregarProd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregarProd.FlatStyle = FlatStyle.Flat;
            btnAgregarProd.ForeColor = Color.FromArgb(26, 138, 94);
            btnAgregarProd.Location = new Point(949, 155);
            btnAgregarProd.Name = "btnAgregarProd";
            btnAgregarProd.Size = new Size(137, 29);
            btnAgregarProd.TabIndex = 3;
            btnAgregarProd.Text = "Agregar Producto";
            btnAgregarProd.UseVisualStyleBackColor = true;
            btnAgregarProd.Click += btnAgregarProd_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(221, 233, 218);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.ForeColor = Color.FromArgb(149, 156, 146);
            txtNombre.Location = new Point(163, 44);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += txtNombre_TextChanged;
            txtNombre.Enter += txtNombre_Enter;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(221, 233, 218);
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.ForeColor = Color.FromArgb(149, 156, 146);
            txtCodigo.Location = new Point(22, 44);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 1;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            txtCodigo.Enter += txtCodigo_Enter;
            txtCodigo.Leave += txtCodigo_Leave;
            // 
            // dgvProducto
            // 
            dgvProducto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducto.BackgroundColor = Color.FromArgb(235, 238, 245);
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Location = new Point(9, 87);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.ReadOnly = true;
            dgvProducto.RowHeadersWidth = 51;
            dgvProducto.RowTemplate.Height = 29;
            dgvProducto.Size = new Size(877, 141);
            dgvProducto.TabIndex = 10;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(957, 100);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 7;
            label4.Text = "Hora:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(952, 67);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker1.CalendarMonthBackground = Color.YellowGreen;
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(1015, 60);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(105, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.BackColor = Color.FromArgb(221, 233, 218);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Enabled = false;
            textBox1.Location = new Point(1015, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(104, 27);
            textBox1.TabIndex = 12;
            // 
            // dgvCarrito
            // 
            dgvCarrito.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.BackgroundColor = Color.FromArgb(235, 238, 245);
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Columns.AddRange(new DataGridViewColumn[] { Id_Inventario, Nombre, Precio, Cantidad, Subtotal });
            dgvCarrito.Location = new Point(15, 36);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.ReadOnly = true;
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.RowTemplate.Height = 29;
            dgvCarrito.Size = new Size(877, 324);
            dgvCarrito.TabIndex = 9;
            // 
            // Id_Inventario
            // 
            Id_Inventario.HeaderText = "Id_Inventario";
            Id_Inventario.MinimumWidth = 6;
            Id_Inventario.Name = "Id_Inventario";
            Id_Inventario.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(btnImprimir);
            groupBox2.Controls.Add(btnAnular);
            groupBox2.Controls.Add(btnGuardar);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtSubTotal);
            groupBox2.Controls.Add(dgvCarrito);
            groupBox2.Location = new Point(22, 421);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1103, 375);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle";
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox7.BackColor = Color.FromArgb(221, 233, 218);
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Location = new Point(955, 161);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(137, 27);
            textBox7.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox6.BackColor = Color.FromArgb(221, 233, 218);
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(955, 112);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(137, 27);
            textBox6.TabIndex = 5;
            // 
            // btnImprimir
            // 
            btnImprimir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.ForeColor = Color.FromArgb(26, 138, 94);
            btnImprimir.Location = new Point(898, 331);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(199, 29);
            btnImprimir.TabIndex = 8;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.MouseEnter += btnImprimir_MouseEnter;
            btnImprimir.MouseLeave += btnImprimir_MouseLeave;
            // 
            // btnAnular
            // 
            btnAnular.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnular.FlatStyle = FlatStyle.Flat;
            btnAnular.ForeColor = Color.Red;
            btnAnular.Location = new Point(1003, 295);
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(94, 29);
            btnAnular.TabIndex = 7;
            btnAnular.Text = "Anular";
            btnAnular.UseVisualStyleBackColor = true;
            btnAnular.MouseEnter += btnAnular_MouseEnter;
            btnAnular.MouseLeave += btnAnular_MouseLeave;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.FromArgb(26, 138, 94);
            btnGuardar.Location = new Point(898, 295);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.MouseEnter += btnGuardar_MouseEnter;
            btnGuardar.MouseLeave += btnGuardar_MouseLeave;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(1037, 89);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 7;
            label7.Text = "Monto";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(1048, 139);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 10;
            label6.Text = "Total";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(1021, 36);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 8;
            label5.Text = "Sub Total";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtSubTotal.BackColor = Color.FromArgb(221, 233, 218);
            txtSubTotal.BorderStyle = BorderStyle.FixedSingle;
            txtSubTotal.Location = new Point(958, 59);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(135, 27);
            txtSubTotal.TabIndex = 14;
            // 
            // FormVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1137, 788);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtVendedor);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVenta";
            Text = "FormVenta";
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtVendedor;
        private GroupBox groupBox1;
        private DataGridView dgvCarrito;
        private GroupBox groupBox2;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox txtSubTotal;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btnImprimir;
        private Button btnAnular;
        private Button btnGuardar;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private TextBox textBox7;
        private TextBox textBox6;
        private GroupBox groupBox3;
        private Button btnEliminarProd;
        private Label label9;
        private Label label8;
        private Button btnAgregarProd;
        private TextBox txtNombre;
        private TextBox txtCodigo;
        private DataGridView dgvProducto;
        private Label label10;
        private NumericUpDown nupCantidad;
        private DataGridViewTextBoxColumn Id_Inventario;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
    }
}