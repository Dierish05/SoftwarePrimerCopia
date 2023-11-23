using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCursoSoftware.Model
{
    public class CompraModel
    {
        private Conexion con;
        public CompraModel(Conexion con)
        {
            this.con = con;
        }

        public void listarCompras(DataGridView GridView1)
        {

            SqlCommand cmd = new SqlCommand();
            SqlDataReader leer;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MostrarCompra";
            cmd.Connection = con.connect;


            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;

        }

        public void CrearDetVenta(string CodProd, float precio, int exist,int porcentaje)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[4];
                param[0] = new SqlParameter("@CodProd", SqlDbType.Char);
                param[0].Value = CodProd;
                param[1] = new SqlParameter("@PrecioP", SqlDbType.Float);
                param[1].Value = precio;
                param[2] = new SqlParameter("@ExistP", SqlDbType.Int);
                param[2].Value = exist;
                param[3] = new SqlParameter("@PorcentajeGanancia", SqlDbType.Int);
                param[3].Value = porcentaje;

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
    }
}
