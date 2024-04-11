using Dapper;
using DotNetDesafio.Domain.Entities;
using DotNetDesafio.Infrastructure.Data.Interface;
using System.Data;

namespace DotNetDesafio.Infrastructure.Data.Repository
{
    public class AlunoRepository : IAlunoRepository
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

        public async Task PostAsync(Aluno aluno)
        {
            using IDbConnection connection = _connectionFactory.CreateConnection();

            connection.Open();

            await connection.ExecuteAsync(
                "INSERT ALUNO VALUES (@name, @senha, @user)",
                new {name = aluno.Nome, senha=aluno.Senha, user = aluno.Usuario});
        }
    }
}
