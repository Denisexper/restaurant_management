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
    public class PersonalData
    {
        private string conexionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        public DataTable obtenerPersonal()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(conexionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Staff", connection))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public bool insertarPersonal(string nombre, string telefono, string role)
        {
            using (SqlConnection connection = new SqlConnection(conexionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Staff (sName, sPhone, sRole) VALUES (@nombre, @telefono, @role)", connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@role", role);

                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        public bool actualizarPersonal(int id, string nombre, string telefono, string role)
        {
            using (SqlConnection connection = new SqlConnection(conexionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Staff SET sName = @nombre, sPhone = @telefono, sRole = @role WHERE staffId = @id", connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@role", role);
                    command.Parameters.AddWithValue("@id", id);

                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        public bool eliminarPersonal(int id)
        {
            using (SqlConnection connection = new SqlConnection(conexionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM Staff WHERE staffId = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }
    }
}
