using ProyectoCursoSoftware.Model;
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
            FormProveedores_01 formProveedores_01 = new FormProveedores_01();
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
    }
}
