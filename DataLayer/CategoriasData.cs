using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CategoriasData
    {
        private string conexionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        public DataTable obtenerCategorias()
        {
            DataTable dt = new DataTable();
            using(SqlConnection connection = new SqlConnection(conexionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Categories", connection))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}
