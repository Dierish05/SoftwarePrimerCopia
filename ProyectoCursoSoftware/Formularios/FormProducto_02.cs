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
        public string IdProveedorSeleccionado { get; set; }
        public string NombreProveedorSeleccionado { get; set; }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            int indiceSeleccionado = dgvDatos.SelectedCells[0].RowIndex;

            int IdProv = 0;
            DataGridViewCell cell = dgvDatos.Rows[indiceSeleccionado].Cells["Id_Prov"];
            if (indiceSeleccionado >= 0)
            {
                

                if (cell.Value != null && cell.Value != DBNull.Value)
                {
                    IdProv = Convert.ToInt32(cell.Value);

                        IdProveedorSeleccionado = IdProv.ToString();
                        NombreProveedorSeleccionado = dgvDatos.Rows[indiceSeleccionado].Cells["Nombre"].Value.ToString();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Este Proveedor no existe! Por favor, seleccione un Proveedor existente.");
                }

                if(IdProv == 0) 
                {
                   
                }
            }
           
            
        }
    }
}
