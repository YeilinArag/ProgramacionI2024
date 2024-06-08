using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_11
{
  
    public class DataAcces
    {
        public const string CONNECTION_STRING = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\cecya\\OneDrive\\Documentos\\ProgramacionI2024\\SEMANA 11\\Semana 11\\Semana 11" +
            "\\Database1.mdf\";Integrated Security=True";

        public List<Alumno> GetAll()
        {
            SqlConnection conn = SqlConnection(CONNECTION_STRING);
            conn.Open();
            string query = "SELECT id, nombres, apellidos, carnet, telefono FROM Alumno";
        }
    }
}
