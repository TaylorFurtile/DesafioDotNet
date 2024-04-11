using Dapper;
using DotNetDesafio.Domain.Entities;
using System.Data;

namespace DotNetDesafio.Infrastructure.Data.Repository
{
    public class AlunoRepository
    {
        private readonly IDbConnectionFactory _connectionFactory;

        public AlunoRepository(IDbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task<IReadOnlyList<Aluno>> GetAllAsync()
        {
            using IDbConnection connection = _connectionFactory.CreateConnection();

            connection.Open();

            var result = await connection.QueryAsync<Aluno>("SELECT * FROM [Aluno]");

            return result.ToList();
        }
    }
}
