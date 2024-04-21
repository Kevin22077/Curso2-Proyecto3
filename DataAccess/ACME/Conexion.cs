using Microsoft.Data.SqlClient;

namespace DataAccess.ACME
{
    public class Conexion
    {
        private readonly string? _cadenaConexion;
        public Conexion()
        {
            string? cadenaConexion;
            // Obtener la cadena de conexion desde variable de entorno
            cadenaConexion = Environment.GetEnvironmentVariable("SQLServerXE");
            _cadenaConexion = cadenaConexion;
        }

        public SqlConnection Conectar()
        {
            SqlConnection sqlConn;
            // Instanciar la conexion utilizando la candena de conexion obtenida
            sqlConn = new SqlConnection(_cadenaConexion);
            return sqlConn;
        }
    }
    
}
