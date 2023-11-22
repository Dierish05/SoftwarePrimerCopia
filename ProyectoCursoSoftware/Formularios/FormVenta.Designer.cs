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
            btnEliminarProd = new Button();
            btnAgregarProd = new Button();
            label9 = new Label();
            label8 = new Label();
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            btnCancelar = new Button();
            btnBuscar = new Button();
            dgvProducto = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            label1.Size = new Size(1001, 38);
            label1.TabIndex = 1;
            label1.Text = "VENTA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 50);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Vendedor";
            // 
            // txtVendedor
            // 
            txtVendedor.BackColor = Color.FromArgb(221, 233, 218);
            txtVendedor.BorderStyle = BorderStyle.FixedSingle;
            txtVendedor.Location = new Point(19, 66);
            txtVendedor.Margin = new Padding(3, 2, 3, 2);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.ReadOnly = true;
            txtVendedor.Size = new Size(338, 23);
            txtVendedor.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(19, 91);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(965, 238);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Principal";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnEliminarProd);
            groupBox3.Controls.Add(btnAgregarProd);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtNombre);
            groupBox3.Controls.Add(txtCodigo);
            groupBox3.Controls.Add(btnCancelar);
            groupBox3.Controls.Add(btnBuscar);
            groupBox3.Controls.Add(dgvProducto);
            groupBox3.Location = new Point(5, 22);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(564, 214);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Buscar Producto";
            // 
            // btnEliminarProd
            // 
            btnEliminarProd.FlatStyle = FlatStyle.Flat;
            btnEliminarProd.ForeColor = Color.FromArgb(26, 138, 94);
            btnEliminarProd.Location = new Point(350, 189);
            btnEliminarProd.Margin = new Padding(3, 2, 3, 2);
            btnEliminarProd.Name = "btnEliminarProd";
            btnEliminarProd.Size = new Size(120, 22);
            btnEliminarProd.TabIndex = 25;
            btnEliminarProd.Text = "Eliminar Producto";
            btnEliminarProd.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProd
            // 
            btnAgregarProd.FlatStyle = FlatStyle.Flat;
            btnAgregarProd.ForeColor = Color.FromArgb(26, 138, 94);
            btnAgregarProd.Location = new Point(350, 155);
            btnAgregarProd.Margin = new Padding(3, 2, 3, 2);
            btnAgregarProd.Name = "btnAgregarProd";
            btnAgregarProd.Size = new Size(120, 22);
            btnAgregarProd.TabIndex = 24;
            btnAgregarProd.Text = "Agregar Producto";
            btnAgregarProd.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(196, 16);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 23;
            label9.Text = "Nombre";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(78, 16);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 22;
            label8.Text = "Codigo";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(221, 233, 218);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.ForeColor = Color.FromArgb(149, 156, 146);
            txtNombre.Location = new Point(143, 33);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(110, 23);
            txtNombre.TabIndex = 21;
            txtNombre.Enter += txtNombre_Enter;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(221, 233, 218);
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.ForeColor = Color.FromArgb(149, 156, 146);
            txtCodigo.Location = new Point(19, 33);
            txtCodigo.Margin = new Padding(3, 2, 3, 2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(110, 23);
            txtCodigo.TabIndex = 20;
            txtCodigo.Enter += txtCodigo_Enter;
            txtCodigo.Leave += txtCodigo_Leave;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.FromArgb(26, 138, 94);
            btnCancelar.Location = new Point(170, 74);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.FromArgb(26, 138, 94);
            btnBuscar.Location = new Point(46, 74);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(82, 22);
            btnBuscar.TabIndex = 18;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvProducto
            // 
            dgvProducto.BackgroundColor = Color.FromArgb(235, 238, 245);
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Location = new Point(11, 111);
            dgvProducto.Margin = new Padding(3, 2, 3, 2);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.RowHeadersWidth = 51;
            dgvProducto.RowTemplate.Height = 29;
            dgvProducto.Size = new Size(319, 100);
            dgvProducto.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(818, 60);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Hora:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(814, 35);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.YellowGreen;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(869, 30);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(92, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(221, 233, 218);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(869, 55);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(91, 23);
            textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(235, 238, 245);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 20);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(767, 232);
            dataGridView1.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(btnImprimir);
            groupBox2.Controls.Add(btnAnular);
            groupBox2.Controls.Add(btnGuardar);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtSubTotal);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(19, 334);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(965, 263);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle";
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(221, 233, 218);
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Location = new Point(814, 129);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(93, 23);
            textBox7.TabIndex = 16;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(221, 233, 218);
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(814, 92);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(93, 23);
            textBox6.TabIndex = 15;
            // 
            // btnImprimir
            // 
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.ForeColor = Color.FromArgb(26, 138, 94);
            btnImprimir.Location = new Point(786, 230);
            btnImprimir.Margin = new Padding(3, 2, 3, 2);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(174, 22);
            btnImprimir.TabIndex = 14;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.MouseEnter += btnImprimir_MouseEnter;
            btnImprimir.MouseLeave += btnImprimir_MouseLeave;
            // 
            // btnAnular
            // 
            btnAnular.FlatStyle = FlatStyle.Flat;
            btnAnular.ForeColor = Color.Red;
            btnAnular.Location = new Point(878, 203);
            btnAnular.Margin = new Padding(3, 2, 3, 2);
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(82, 22);
            btnAnular.TabIndex = 13;
            btnAnular.Text = "Anular";
            btnAnular.UseVisualStyleBackColor = true;
            btnAnular.MouseEnter += btnAnular_MouseEnter;
            btnAnular.MouseLeave += btnAnular_MouseLeave;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.FromArgb(26, 138, 94);
            btnGuardar.Location = new Point(786, 203);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 22);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.MouseEnter += btnGuardar_MouseEnter;
            btnGuardar.MouseLeave += btnGuardar_MouseLeave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(858, 75);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 7;
            label7.Text = "Monto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(868, 112);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 10;
            label6.Text = "Total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(844, 35);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 8;
            label5.Text = "Sub Total";
            // 
            // txtSubTotal
            // 
            txtSubTotal.BackColor = Color.FromArgb(221, 233, 218);
            txtSubTotal.BorderStyle = BorderStyle.FixedSingle;
            txtSubTotal.Location = new Point(816, 52);
            txtSubTotal.Margin = new Padding(3, 2, 3, 2);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(91, 23);
            txtSubTotal.TabIndex = 6;
            // 
            // FormVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(995, 591);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtVendedor);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormVenta";
            Text = "FormVenta";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
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
        private GroupBox groupBox3;
        private Button btnEliminarProd;
        private Button btnAgregarProd;
        private Label label9;
        private Label label8;
        private TextBox txtNombre;
        private TextBox txtCodigo;
        private Button btnCancelar;
        private Button btnBuscar;
        private DataGridView dgvProducto;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private TextBox textBox7;
        private TextBox textBox6;
    }
}