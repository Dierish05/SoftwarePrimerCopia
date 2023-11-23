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
    public partial class FormProducto_02 : Form
    {
        Conexion con;
        private ProveedorModel pm;
        public FormProducto_02(Conexion con)
        {
            InitializeComponent();
            pm = new ProveedorModel(con);
            this.con = con;
            Listar();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == string.Empty)
            {

            }
        }
        private void Listar()
        {
            pm.listarProveedores(dgvDatos);
        }
    }
}
