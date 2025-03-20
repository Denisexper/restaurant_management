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
    public class TablesData
    {
        private string conexionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        public DataTable obtenerTables()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(conexionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Tabless", connection))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public bool insertarTable(string nombre)
        {
            using (SqlConnection connection = new SqlConnection(conexionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Tabless (nameTable) VALUES (@nombre)", connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);

                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        public bool actualizarTable(int id, string nombre)
        {
            using (SqlConnection connection = new SqlConnection(conexionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Tabless SET nameTable = @nombre WHERE idTable = @id", connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@id", id);

                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        public bool eliminarTable(int id)
        {
            using (SqlConnection connection = new SqlConnection(conexionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM Tabless WHERE idTable = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }
    }
}
