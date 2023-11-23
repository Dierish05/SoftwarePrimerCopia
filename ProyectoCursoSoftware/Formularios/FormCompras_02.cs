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
    public partial class FormCompras_02 : Form
    {
        Conexion con;
        private ProductoModel cm;
        public string CodProductoSeleccionado { get; set; }
        public string NombreProductoSeleccionado { get; set; }
        public FormCompras_02(Conexion con)
        {
            InitializeComponent();
            cm = new ProductoModel(con);
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
            cm.listarProductos(dgvDatos);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            int indiceSeleccionado = dgvDatos.SelectedCells[0].RowIndex;
            CodProductoSeleccionado = dgvDatos.Rows[indiceSeleccionado].Cells["CodProd"].Value.ToString();
            NombreProductoSeleccionado = dgvDatos.Rows[indiceSeleccionado].Cells["Nombre del prodcuto"].Value.ToString();


            this.Close();
        }
    }
}
