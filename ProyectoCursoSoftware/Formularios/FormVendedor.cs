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
    public partial class FormVendedor : Form
    {
        private Conexion con;
        private VendedorModel vm;
        public FormVendedor(Conexion Con)
        {
            this.con = Con;
            vm = new VendedorModel(con);
            InitializeComponent();
            listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormVendedor_01 formVendedor_01 = new FormVendedor_01(vm);
            formVendedor_01.ShowDialog();
        }

        private void listar()
        {
            vm.listarVendedores(dgvDatos);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            vm.listarVendedores(dgvDatos);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != string.Empty)
            {
                vm.BusquedaVendedorNombre(txtNombre.Text, dgvDatos);
            }
            else if (txtApellido.Text != string.Empty)
            {
                vm.BusquedaVendedorApellido(txtApellido.Text, dgvDatos);
            }
            else
            {
                listar();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != string.Empty && txtApellido.Text == string.Empty)
            {
                vm.BusquedaVendedorNombre(txtNombre.Text, dgvDatos);
            }
            else if (txtNombre.Text == string.Empty && txtApellido.Text == string.Empty)
            {
                listar();
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == string.Empty && txtApellido.Text != string.Empty)
            {
                vm.BusquedaVendedorApellido(txtApellido.Text, dgvDatos);
            }
            else if (txtNombre.Text == string.Empty && txtApellido.Text == string.Empty)
            {
                listar();
            }
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
                DataGridViewCell cell = dgvDatos.Rows[indiceSeleccionado].Cells["Id_Vendedores"];
                if (cell.Value != null && cell.Value != DBNull.Value)
                {

                    FormVendedor_02 formVendedor_02 = new FormVendedor_02(vm);
                    formVendedor_02.txtId.Text = dgvDatos.Rows[indiceSeleccionado].Cells["Id_Vendedores"].Value.ToString();
                    formVendedor_02.txtPrimerNombre.Text = dgvDatos.Rows[indiceSeleccionado].Cells["Nombre"].Value.ToString();
                    formVendedor_02.txtPrimerApellido.Text = dgvDatos.Rows[indiceSeleccionado].Cells["Apellido"].Value.ToString();
                    formVendedor_02.txtEmail.Text = dgvDatos.Rows[indiceSeleccionado].Cells["Email"].Value.ToString();
                    if (dgvDatos.Rows[indiceSeleccionado].Cells["Sexo"].Value.ToString() == "F")
                    {
                        formVendedor_02.rbtnFemenino.Checked = true;
                    }
                    else if (dgvDatos.Rows[indiceSeleccionado].Cells["Sexo"].Value.ToString() == "M")
                    {
                        formVendedor_02.rbtnMasculino.Checked = true;
                    }
                    //formVendedor_01.genero.Text = dgvDatos.Rows[indiceSeleccionado].Cells["Sexo"].Value.ToString();
                    formVendedor_02.txtCedula.Text = dgvDatos.Rows[indiceSeleccionado].Cells["Cedula"].Value.ToString();
                    formVendedor_02.txtTelefono.Text = dgvDatos.Rows[indiceSeleccionado].Cells["Telefono"].Value.ToString();
                    formVendedor_02.cmbMunicipio.Text = dgvDatos.Rows[indiceSeleccionado].Cells["Municipio"].Value.ToString();
                    formVendedor_02.ShowDialog();
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
                DataGridViewCell cell = dgvDatos.Rows[indiceSeleccionado].Cells["Id_Vendedores"];
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
            listar();
        }
    }
}
