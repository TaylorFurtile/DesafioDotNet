using DotNetDesafio.Domain.Entities;

namespace DotNetDesafio.Infrastructure.Data.Interface
{
    public interface IAlunoRepository
    {
        Task<IReadOnlyList<Aluno>> GetAllAsync();
        Task PostAsync(Aluno aluno);
    }
}
