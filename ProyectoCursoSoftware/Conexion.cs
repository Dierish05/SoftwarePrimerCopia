using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


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
                string query = $"SELECT r.name FROM Proyecto.sys.database_principals p JOIN Proyecto.sys.database_role_members m ON p.principal_id = m.member_principal_id JOIN Proyecto.sys.database_principals r ON m.role_principal_id = r.principal_id WHERE p.name = '{user}'";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string userRole = reader["name"].ToString();

                            if (userRole == "Vendedor")
                            {
                                // Abrir el formulario para dbcreator
                                rol = "Vendedor";
                            }
                            else if (userRole == "Gerente")
                            {
                                // Abrir el formulario para sysadmin
                                rol = "Gerente";
                            }
                            else
                            {
                                MessageBox.Show("No tienes roles específicos asignados.");
                            }
                        }
                        else
                        {
                            //MessageBox.Show("Error al verificar roles.");
                            rol = "sysadmin";
                            connect.Close();
                        }

                    }

                        
                }
            }
            catch (Exception)
            {


            }
        }
    }
}
