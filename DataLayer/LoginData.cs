using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DataLayer
{
    public class LoginData
    {
        public bool ValidarUsuario(string username, string userpassword)
        {
            string conexionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conexionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE username = @username AND userpassword = @userpassword", con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@userpassword", userpassword);

                    object result = cmd.ExecuteScalar();
                    int count = (result != null) ? Convert.ToInt32(result) : 0;
                    return count > 0;
                }
            }
        }
    }
}
