using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCursoSoftware.Model
{
    public class ProductoModel
    {
        private Conexion con;
        public ProductoModel(Conexion con)
        {
            this.con = con;
        }

        public void listarProductos(DataGridView GridView1)
        {

            SqlCommand cmd = new SqlCommand();
            SqlDataReader leer;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MostrarProductos";
            cmd.Connection = con.connect;


            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;

        }

        public void CrearProducto(String Cod, string Nombre, string Desc, int IdProv, int IdCat)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[5];
                param[0] = new SqlParameter("@CodP", SqlDbType.Char);
                param[0].Value = Cod;
                param[1] = new SqlParameter("@NombreP", SqlDbType.NVarChar);
                param[1].Value = Nombre;
                param[2] = new SqlParameter("@DescP", SqlDbType.NVarChar);
                param[2].Value = Desc;
                param[3] = new SqlParameter("@IdProv", SqlDbType.Int);
                param[3].Value = IdProv;
                param[4] = new SqlParameter("@IdCat", SqlDbType.Int);
                param[4].Value = IdCat;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CrearProducto";
                cmd.Connection = con.connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al Crear el producto");
                return;
            }
        }

        public void BusquedaProductoId(string id, DataGridView gridView)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@Id", SqlDbType.NVarChar);
                param[0].Value = id;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BusquedaProductoId";
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
        public void BusquedaProductosNombre(string Nombre, DataGridView gridView)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@Nombre", SqlDbType.NVarChar);
                param[0].Value = Nombre;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BusquedaProductosNombre";
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

        public void BusquedaProductoCategoria(int id, DataGridView gridView)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@Id", SqlDbType.Int);
                param[0].Value = id;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BusquedaProductosIdCategoria";
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
    }
}
