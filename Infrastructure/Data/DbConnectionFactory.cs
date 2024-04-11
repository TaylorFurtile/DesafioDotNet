using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace DotNetDesafio.Infrastructure.Data
{
    public class DbConnectionFactory(IConfiguration configuration) : IDbConnectionFactory
    {
        private readonly IConfiguration _configuration = configuration;

        public string? GetConnectionString() => _configuration.GetConnectionString("Default");

        public SqlConnection CreateConnection()
        {
            string? connectionString = GetConnectionString();

            if (connectionString == null)
                throw new ArgumentNullException("Connection string could not be found.");

            return new SqlConnection(connectionString);
        }
    }
}
