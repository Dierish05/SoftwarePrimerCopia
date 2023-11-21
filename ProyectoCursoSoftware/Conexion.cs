using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoCursoSoftware
{
    public class Conexion
    {
        public SqlConnection connect = new SqlConnection();

        public Conexion(String user, String pass)
        {
            try
            {

                connect = new SqlConnection("Server=localhost;Database=Proyecto;UID=" + user + ";PWD=" + pass);
                //connect = new SqlConnection("Server=DESKTOP-B2TA6M2;Database=odonto;UID=" + user + ";PWD=" + pass);
                connect.Open();
            }
            catch (Exception)
            {


            }
        }
    }
}
