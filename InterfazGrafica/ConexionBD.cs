using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace InterfazGrafica
{
    internal class ConexionBD
    {
        // Cambia 'bd_proyecto' por el nombre exacto que le pusiste en SSMS
        private string cadena = @"Server=(localdb)\MSSQLLocalDB;Database=bd_proyecto;Integrated Security=True;TrustServerCertificate=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(cadena);
        }

        // Este método ahora solo se asegura de que la TABLA exista
        public void ValidarTabla()
        {
            string queryTabla = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Usuarios')
                BEGIN
                    CREATE TABLE Usuarios (
                        ID INT PRIMARY KEY IDENTITY(1,1),
                        Nombre NVARCHAR(100) NOT NULL,
                        Detalle NVARCHAR(250),
                        FechaRegistro DATETIME DEFAULT GETDATE()
                    );
                END";

            using (SqlConnection con = GetConnection())
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(queryTabla, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al validar la tabla: " + ex.Message);
                }
            }
        }

        public DataTable ObtenerDatos(string consulta)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
                adapter.Fill(tabla);
            }
            return tabla;
        }
    }
}