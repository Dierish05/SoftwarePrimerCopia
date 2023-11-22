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
        public string rol;
        public SqlConnection connect = new SqlConnection();

        public Conexion(String user, String pass)
        {
            try
            {
                connect = new SqlConnection("Data Source=localhost;Initial Catalog=Proyecto;User Id=" + user + ";Password=" + pass + ";");


                //connect = new SqlConnection("Server=DESKTOP-B2TA6M2;Database=odonto;UID=" + user + ";PWD=" + pass);
                connect.Open();
                string query = @"SELECT 
                                    CASE
                                        WHEN 'dbcreator' IN (SELECT r.name FROM sys.server_role_members m JOIN sys.server_principals r ON m.role_principal_id = r.principal_id WHERE m.member_principal_id = SUSER_ID()) THEN 'dbcreator'
                                        WHEN 'sysadmin' IN (SELECT r.name FROM sys.server_role_members m JOIN sys.server_principals r ON m.role_principal_id = r.principal_id WHERE m.member_principal_id = SUSER_ID()) THEN 'sysadmin'
                                        ELSE 'OtroRol'
                                    END AS UserRole";
                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string userRole = reader["UserRole"].ToString();

                        if (userRole == "dbcreator")
                        {
                            // Abrir el formulario para dbcreator
                            rol = "dbcreator";
                        }
                        else if (userRole == "sysadmin")
                        {
                            // Abrir el formulario para sysadmin
                            rol = "sysadmin";
                        }
                        else
                        {
                            MessageBox.Show("No tienes roles específicos asignados.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al verificar roles.");
                    }
                }
            }
            catch (Exception)
            {


            }
        }
    }
}
