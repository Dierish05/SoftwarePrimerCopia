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
            dgvDatos = new DataGridView();
            label1 = new Label();
            btnSeleccionar = new Button();
            btnCancelar = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(9, 82);
            dgvDatos.Margin = new Padding(3, 2, 3, 2);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.RowTemplate.Height = 29;
            dgvDatos.Size = new Size(560, 193);
            dgvDatos.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1, -2);
            label1.Name = "label1";
            label1.Size = new Size(578, 23);
            label1.TabIndex = 68;
            label1.Text = "SELECCION PROVEEDOR";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.FlatStyle = FlatStyle.Flat;
            btnSeleccionar.ForeColor = Color.FromArgb(26, 138, 94);
            btnSeleccionar.Location = new Point(10, 280);
            btnSeleccionar.Margin = new Padding(3, 2, 3, 2);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(104, 31);
            btnSeleccionar.TabIndex = 69;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.FromArgb(26, 138, 94);
            btnCancelar.Location = new Point(125, 280);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 31);
            btnCancelar.TabIndex = 70;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Location = new Point(10, 26);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(248, 52);
            groupBox1.TabIndex = 71;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 25);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(221, 233, 218);
            txtNombre.Location = new Point(69, 20);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(169, 23);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // FormProducto_02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(579, 320);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnSeleccionar);
            Controls.Add(label1);
            Controls.Add(dgvDatos);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormProducto_02";
            Text = "FormProducto_02";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDatos;
        private Label label1;
        private Button btnSeleccionar;
        private Button btnCancelar;
        private GroupBox groupBox1;
        private TextBox txtNombre;
        private Label label2;
    }
}