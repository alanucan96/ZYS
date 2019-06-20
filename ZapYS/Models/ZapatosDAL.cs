using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ZapYS.Models
{
    public class ZapatosDAL
    {
        public ZapatosDAL()
        {

        }

        string connectionString = "Server=sql5018.site4now.net;uid=DB_A4A01E_zys_admin;password=a15091225;Database=DB_A4A01E_zys;";


        //To View all employees details             
        public IEnumerable<Zapatos> ListarZapatos()
        {
            List<Zapatos> ListaZapatos = new List<Zapatos>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Zapatos", con);
                cmd.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Zapatos oZapatos = new Zapatos()
                    {
                        ID = Convert.ToInt32(rdr["ID"]),
                        genero = rdr["genero"].ToString(),
                        modelo = rdr["modelo"].ToString(),
                        img = rdr["img"].ToString(),
                        talla = Convert.ToInt32(rdr["talla"])
                    };

                    ListaZapatos.Add(oZapatos);
                }
                con.Close();
            }

            return ListaZapatos;
        }

        //To Add new employee record             
        public void AgregarEmpleados(Zapatos oZapatos)
        {

        }

        //To Update the records of a particluar employee          
        public void ModificarEmpleados(Zapatos oZapatos)
        {

        }

        //Get the details of a particular employee         
        public Zapatos ObtenerDatosTrabajador(int? ID)
        {
            return new Zapatos();
        }

        //To Delete the record on a particular employee        
        public void BorrarEmpleado(int? ID)
        {

        }
    }
}