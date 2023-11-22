namespace ProyectoCursoSoftware.Formularios
{
    partial class FormProducto_02
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnSeleccionar = new Button();
            btnCancelar = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(640, 257);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1, -3);
            label1.Name = "label1";
            label1.Size = new Size(661, 31);
            label1.TabIndex = 68;
            label1.Text = "SELECCION PROVEEDOR";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.FlatStyle = FlatStyle.Flat;
            btnSeleccionar.ForeColor = Color.FromArgb(26, 138, 94);
            btnSeleccionar.Location = new Point(12, 374);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(119, 41);
            btnSeleccionar.TabIndex = 69;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.FromArgb(26, 138, 94);
            btnCancelar.Location = new Point(143, 373);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 41);
            btnCancelar.TabIndex = 70;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Location = new Point(12, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(284, 70);
            groupBox1.TabIndex = 71;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 33);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(221, 233, 218);
            txtNombre.Location = new Point(79, 26);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(193, 27);
            txtNombre.TabIndex = 0;
            // 
            // FormProducto_02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(662, 427);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnSeleccionar);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProducto_02";
            Text = "FormProducto_02";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btnSeleccionar;
        private Button btnCancelar;
        private GroupBox groupBox1;
        private TextBox txtNombre;
        private Label label2;
    }
}