using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ZapYS.Models
{
    public class UsersDAL
    {
        string connectionString = "Server=sql5018.site4now.net;uid=DB_A4A01E_zys_admin;password=a15091225;Database=DB_A4A01E_zys;";


        //To View all employees details             
        public IEnumerable<Users> ListarUsuarios()
        {
            List<Users> ListaUsuarios = new List<Users>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users", con);
                cmd.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Users oUser = new Users()
                    {
                        ID = Convert.ToInt32(rdr["ID"]),
                        correo = rdr["user"].ToString(),
                        password = rdr["password"].ToString()
                    };

                    ListaUsuarios.Add(oUser);
                }
                con.Close();
            }

            return ListaUsuarios;
        }

        public IEnumerable<Users> Login(String u, String p)
        {
            List<Users> ListaUsuarios = new List<Users>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE [user] = '" + u + "' AND password = '" + p + "'", con);
                cmd.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Users oUser = new Users()
                    {
                        ID = Convert.ToInt32(rdr["ID"]),
                        correo = rdr["user"].ToString(),
                        password = rdr["password"].ToString()
                    };

                    ListaUsuarios.Add(oUser);
                }
                con.Close();
            }

            return ListaUsuarios;
        }

        //To Add new employee record             
        public void AgregarEmpleados(Users oUser)
        {

        }

        //To Update the records of a particluar employee          
        public void ModificarEmpleados(Users oUser)
        {

        }

        //Get the details of a particular employee         
        public Users ObtenerDatosTrabajador(int? ID)
        {
            return new Users();
        }

        //To Delete the record on a particular employee        
        public void BorrarEmpleado(int? ID)
        {

        }
    }
}