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
            if (txtNombre.Text == string.Empty && txtApellido.Text == string.Empty)
            {
                listar();
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == string.Empty && txtApellido.Text == string.Empty)
            {
                listar();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
