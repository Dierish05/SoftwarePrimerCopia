using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCursoSoftware.Model
{
    public class VentaModel
    {
        private Conexion con;
        public VentaModel(Conexion con)
        {
            this.con = con;
        }

        public void listarVentas(DataGridView GridView1)
        {

            SqlCommand cmd = new SqlCommand();
            SqlDataReader leer;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MostrarVentas";
            cmd.Connection = con.connect;


            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;

        }

        public void listarVentasId(DataGridView GridView1)
        {

            SqlCommand cmd = new SqlCommand();
            SqlDataReader leer;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "listarVentas";
            cmd.Connection = con.connect;


            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;

        }

        public void CrearVenta(int Vendedor)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@IdEmp", SqlDbType.Int);
                param[0].Value = Vendedor;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CrearVentaP";
                cmd.Connection = con.connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al Crear la venta");
                return;
            }
        }

        public void CrearDetVenta(int idVenta, int IdInv, int cant)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[3];
                param[0] = new SqlParameter("@IdVenta", SqlDbType.Int);
                param[0].Value = idVenta;
                param[1] = new SqlParameter("@IdInv", SqlDbType.Int);
                param[1].Value = IdInv;
                param[2] = new SqlParameter("@cants", SqlDbType.Int);
                param[2].Value = cant;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "NDetProducto";
                cmd.Connection = con.connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al Crear el detalle de venta");
                return;
            }
        }

        public void BusquedaInventarioNombre(string Nombre, DataGridView gridView)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@Nombre", SqlDbType.NVarChar);
                param[0].Value = Nombre;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BusquedaInventarioNombre";
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

        public void BusquedaInventarioCodigo(string codigo, DataGridView gridView)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@Id", SqlDbType.NVarChar);
                param[0].Value = codigo;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BusquedaInventarioId";
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

        public void SumarVenta(int IdInv, int Cantidad)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@Id_Inv", SqlDbType.Int);
                param[0].Value = IdInv;
                param[1] = new SqlParameter("@Cant", SqlDbType.Int);
                param[1].Value = Cantidad;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SumarVenta";
                cmd.Connection = con.connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al actualizar");
                return;
            }
        }

        public void RestarVenta(int IdInv, int Cantidad)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@Id_Inv", SqlDbType.Int);
                param[0].Value = IdInv;
                param[1] = new SqlParameter("@Cant", SqlDbType.Int);
                param[1].Value = Cantidad;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RestarVenta";
                cmd.Connection = con.connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al actualizar");
                return;
            }
        }
    }
}
