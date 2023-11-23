using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCursoSoftware.Model
{
    public class ProveedorModel
    {
        private Conexion con;
        public ProveedorModel(Conexion con)
        {
            this.con = con;
        }

        public void listarProveedores(DataGridView GridView1)
        {

            SqlCommand cmd = new SqlCommand();
            SqlDataReader leer;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MostrarProveedores";
            cmd.Connection = con.connect;


            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;

        }

        public void BusquedaProveedorNombre(string Nombre, DataGridView gridView)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@Nombre", SqlDbType.NVarChar);
                param[0].Value = Nombre;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BusquedaProveedorNombre";
                cmd.Connection = con.connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                gridView.DataSource = dt;
            }
            catch (Exception)
            {

                MessageBox.Show("Error en la busqueda");
                return;
            }

        }

        public void CrearProveedor(string Nombre, string Dir, string Tel, string Email)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[4];
                param[0] = new SqlParameter("@Nombre", SqlDbType.NVarChar);
                param[0].Value = Nombre;
                param[1] = new SqlParameter("@Dir", SqlDbType.NVarChar);
                param[1].Value = Dir;
                param[2] = new SqlParameter("@Tel", SqlDbType.Char);
                param[2].Value = Tel;
                param[3] = new SqlParameter("@Email", SqlDbType.NVarChar);
                param[3].Value = Email;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CrearProveedor";
                cmd.Connection = con.connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al Crear Proveedor");
                return;
            }
        }
    }
}
