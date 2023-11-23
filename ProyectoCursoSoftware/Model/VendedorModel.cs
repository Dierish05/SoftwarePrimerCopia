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

        public void CrearVendedor(String PNV, String SNV, String PAV, string SAV, string Dir, string tel, char sex, int mun, string email, string NCedula, string usuario)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[11];
                param[0] = new SqlParameter("@PNV", SqlDbType.NVarChar);
                param[0].Value = PNV;
                param[1] = new SqlParameter("@SNV", SqlDbType.NVarChar);
                param[1].Value = SNV;
                param[2] = new SqlParameter("@PAV", SqlDbType.NVarChar);
                param[2].Value = PAV;
                param[3] = new SqlParameter("@SAV", SqlDbType.NVarChar);
                param[3].Value = SAV;
                param[4] = new SqlParameter("@Dir", SqlDbType.NVarChar);
                param[4].Value = Dir;
                param[5] = new SqlParameter("@Tel", SqlDbType.Char);
                param[5].Value = tel;
                param[6] = new SqlParameter("@Sexo", SqlDbType.Char);
                param[6].Value = sex;
                param[7] = new SqlParameter("@Id_Mun", SqlDbType.Int);
                param[7].Value = mun;
                param[8] = new SqlParameter("@Email", SqlDbType.NVarChar);
                param[8].Value = email;
                param[9] = new SqlParameter("@NCedulaEmp", SqlDbType.Char);
                param[9].Value = NCedula;
                param[10] = new SqlParameter("@usuario", SqlDbType.Char);
                param[10].Value = usuario;


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

        public void BusquedaVendedorUsuario(string Nombre, DataGridView gridView)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@Nombre", SqlDbType.NVarChar);
                param[0].Value = Nombre;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BuscarVendedorUsuario";
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

        public void CrearLoginVendedor(String usuario, string contrasena)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@Usuario", SqlDbType.NVarChar);
                param[0].Value = usuario;
                param[1] = new SqlParameter("@Contraseña", SqlDbType.NVarChar);
                param[1].Value = contrasena;


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "NuevosLogin";
                cmd.Connection = con.connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al Crear el login");
                return;
            }
        }
    }
}
