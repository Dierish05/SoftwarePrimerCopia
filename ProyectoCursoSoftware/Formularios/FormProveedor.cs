﻿using ProyectoCursoSoftware.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCursoSoftware.Formularios
{
    public partial class FormProveedor : Form
    {
        private Conexion con;
        private ProveedorModel pm;
        public FormProveedor(Conexion Con)
        {
            this.con = Con;
            pm = new ProveedorModel(con);
            InitializeComponent();
            Listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormProveedores_01 formProveedores_01 = new FormProveedores_01(pm);
            formProveedores_01.ShowDialog();
        }

        private void Listar()
        {
            pm.listarProveedores(dgvDatos);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedCells.Count == 0)
            {
                MessageBox.Show("No tiene ningun producto seleccionado! seleccione un producto e intentelo nuevamente");
            }
            else
            {
                int indiceSeleccionado = dgvDatos.SelectedCells[0].RowIndex;
                DataGridViewCell cell = dgvDatos.Rows[indiceSeleccionado].Cells["Id_Prov"];
                if (cell.Value != null && cell.Value != DBNull.Value)
                {
                    FormProveedores_01 formProveedores_01 = new FormProveedores_01(pm);
                    formProveedores_01.txtId.Text = dgvDatos.Rows[indiceSeleccionado].Cells["Id_Prov"].Value.ToString();
                    formProveedores_01.txtNombre.Text = dgvDatos.Rows[indiceSeleccionado].Cells["Nombre"].Value.ToString();
                    formProveedores_01.txtDireccion.Text = dgvDatos.Rows[indiceSeleccionado].Cells["Direccion"].Value.ToString();
                    formProveedores_01.txtTelefono.Text = dgvDatos.Rows[indiceSeleccionado].Cells["Tel"].Value.ToString();
                    formProveedores_01.txtEmail.Text = dgvDatos.Rows[indiceSeleccionado].Cells["Email"].Value.ToString();
                    formProveedores_01.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No tiene ningun producto seleccionado! seleccione un producto e intentelo nuevamente");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedCells.Count == 0)
            {
                MessageBox.Show("No tiene ningun producto seleccionado! seleccione un producto e intentelo nuevamente");
            }
            else
            {
                int indiceSeleccionado = dgvDatos.SelectedCells[0].RowIndex;
                DataGridViewCell cell = dgvDatos.Rows[indiceSeleccionado].Cells["Id_Prov"];
                if (cell.Value != null && cell.Value != DBNull.Value)
                {

                    //Funcion eliminar xde
                }
                else
                {
                    MessageBox.Show("No tiene ningun producto seleccionado! seleccione un producto e intentelo nuevamente");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                pm.BusquedaProveedorNombre(textBox1.Text, dgvDatos);
            }
            else
            {
                Listar();
            }
        }
    }
}
