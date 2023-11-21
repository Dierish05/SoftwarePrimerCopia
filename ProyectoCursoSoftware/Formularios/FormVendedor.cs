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
        public FormVendedor()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormVendedor_01 formVendedor_01 = new FormVendedor_01();
            formVendedor_01.ShowDialog();
        }
    }
}
