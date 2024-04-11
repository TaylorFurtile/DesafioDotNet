using System.Data.SqlClient;

namespace DotNetDesafio.Infrastructure.Data
{
    public interface IDbConnectionFactory
    {
        public string? GetConnectionString();
        public SqlConnection CreateConnection();
    }
}
