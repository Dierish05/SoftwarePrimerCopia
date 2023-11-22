﻿namespace ProyectoCursoSoftware.Formularios
{
    partial class FormVendedor
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
            groupBox1 = new GroupBox();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            dgvDatos = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(-5, 0);
            label1.Name = "label1";
            label1.Size = new Size(1144, 51);
            label1.TabIndex = 0;
            label1.Text = "BUSQUEDA Y MANTENIMIENTO DE VENDEDOR";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(lblApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(11, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(585, 82);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(363, 27);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(193, 27);
            txtApellido.TabIndex = 9;
            txtApellido.TextChanged += txtApellido_TextChanged;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(294, 27);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 20);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(89, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(193, 27);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 27);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // dgvDatos
            // 
            dgvDatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(11, 215);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.RowTemplate.Height = 29;
            dgvDatos.Size = new Size(991, 337);
            dgvDatos.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregar.Location = new Point(1021, 355);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Nuevo";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditar.Location = new Point(1021, 408);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.Location = new Point(1021, 467);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.Location = new Point(1021, 523);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // FormVendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1137, 595);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvDatos);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVendedor";
            Text = "FormVendedor";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtNombre;
        private Label label2;
        private DataGridView dgvDatos;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnSalir;
        private TextBox txtApellido;
        private Label lblApellido;
    }
}