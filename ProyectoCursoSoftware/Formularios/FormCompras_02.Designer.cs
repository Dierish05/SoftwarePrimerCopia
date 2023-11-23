namespace ProyectoCursoSoftware.Formularios
{
    partial class FormCompras_02
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtNombre = new TextBox();
            btnCancelar = new Button();
            btnSeleccionar = new Button();
            label1 = new Label();
            dgvDatos = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Location = new Point(10, 28);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(248, 52);
            groupBox1.TabIndex = 76;
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
            txtNombre.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.FromArgb(26, 138, 94);
            btnCancelar.Location = new Point(125, 282);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 31);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.FlatStyle = FlatStyle.Flat;
            btnSeleccionar.ForeColor = Color.FromArgb(26, 138, 94);
            btnSeleccionar.Location = new Point(10, 283);
            btnSeleccionar.Margin = new Padding(3, 2, 3, 2);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(104, 31);
            btnSeleccionar.TabIndex = 2;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(-1, 0);
            label1.Name = "label1";
            label1.Size = new Size(580, 23);
            label1.TabIndex = 73;
            label1.Text = "SELECCION PRODUCTO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvDatos
            // 
            dgvDatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.BackgroundColor = Color.FromArgb(235, 238, 245);
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(9, 85);
            dgvDatos.Margin = new Padding(3, 2, 3, 2);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.RowTemplate.Height = 29;
            dgvDatos.Size = new Size(560, 193);
            dgvDatos.TabIndex = 4;
            // 
            // FormCompras_02
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
            Name = "FormCompras_02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCompras_02";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtNombre;
        private Button btnCancelar;
        private Button btnSeleccionar;
        private Label label1;
        private DataGridView dgvDatos;
    }
}