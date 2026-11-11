
using Microsoft.Data.SqlClient;

namespace Acabiblioteca.Datos
{
    public class Conexion
    {
        private static readonly string cadenaConexion =
            @"Server=(localdb)\MSSQLLocalDB;Database=AcaBiblioteca;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public static bool ProbarConexion(out string mensaje)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    mensaje = "Conexión exitosa con la base de datos AcaBiblioteca.";
                    return true;
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al conectar con SQL Server: " + ex.Message;
                return false;
            }
        }
    }
}
