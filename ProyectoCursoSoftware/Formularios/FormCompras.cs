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
    public partial class FormCompras : Form
    {
        private Conexion con;
        private CompraModel cm;
        public FormCompras(Conexion Con)
        {
            this.con = Con;
            cm = new CompraModel(con);
            InitializeComponent();
            Listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormCompras_01 formCompras_01 = new FormCompras_01();
            formCompras_01.ShowDialog();
        }

        private void Listar()
        {
            cm.listarCompras(dgvDatos);
        }
    }
}
