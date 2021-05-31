using System.Data.SqlClient;

namespace Controle_de_entregas.Classes
{
    public class Conectar
    {
        public SqlConnection GetConnection()
        {
            var cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=entregas;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            cnn.Open();

            return cnn;
        }
    }
}
