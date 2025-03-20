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

        //Metodo para obtener una categoria por su id barra de busqueda
        public DataTable obtenerCategoriaPorId(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(conexionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Categories WHERE CategoryID = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        //Metodo para insertar una categoria
        public bool insertarCategoria(string nombre)
        {
            using (SqlConnection connection = new SqlConnection(conexionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Categories (nameCategorie) VALUES (@nombre)", connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.ExecuteNonQuery();

                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        //Metodo para actualizar una categoria
        public bool actualizarCategoria(int id, string nombre)
        {
            using (SqlConnection connection = new SqlConnection(conexionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Categories SET nameCategorie = @nombre WHERE CategoryID = @id", connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@id", id);

                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        //Metodo para eliminar una categoria
        public bool eliminarCategoria(int id)
        {
            using (SqlConnection connection = new SqlConnection(conexionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM Categories WHERE CategoryID = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }
    }
}
