using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCursoSoftware.Model
{
    public class VendedorModel
    {
        private Conexion con;
        public VendedorModel(Conexion con)
        {
            this.con = con;
        }

        public void listarVendedores(DataGridView GridView1)
        {

            SqlCommand cmd = new SqlCommand();
            SqlDataReader leer;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MostrarVendedor";
            cmd.Connection = con.connect;


            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;

        }

        public void CrearVendedor(String Nombres, string Apellidos, string Dir, string tel, char sex, int mun, string email, string NCedula)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[8];
                param[0] = new SqlParameter("@Nombres", SqlDbType.NVarChar);
                param[0].Value = Nombres;
                param[1] = new SqlParameter("@Apellidos", SqlDbType.NVarChar);
                param[1].Value = Apellidos;
                param[2] = new SqlParameter("@Dir", SqlDbType.NVarChar);
                param[2].Value = Dir;
                param[3] = new SqlParameter("@Tel", SqlDbType.Char);
                param[3].Value = tel;
                param[4] = new SqlParameter("@Sexo", SqlDbType.Char);
                param[4].Value = sex;
                param[5] = new SqlParameter("@Id_Mun", SqlDbType.Int);
                param[5].Value = mun;
                param[6] = new SqlParameter("@Email", SqlDbType.NVarChar);
                param[6].Value = email;
                param[7] = new SqlParameter("@NCedulaEmp", SqlDbType.Char);
                param[7].Value = NCedula;


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CrearVendedor";
                cmd.Connection = con.connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al Crear el Vendedor");
                return;
            }
        }

        public void BusquedaVendedorNombre(string Nombre, DataGridView gridView)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@Nombre", SqlDbType.NVarChar);
                param[0].Value = Nombre;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BuscarVendedorNombre";
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

        public void BusquedaVendedorApellido(string Nombre, DataGridView gridView)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@Apellido", SqlDbType.NVarChar);
                param[0].Value = Nombre;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BuscarVendedorApellido";
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
