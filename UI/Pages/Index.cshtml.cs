using DotNetDesafio.Domain.Entities;
using DotNetDesafio.Infrastructure.Data.Interface;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetDesafio.UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IAlunoRepository _alunoRepository;
        public IEnumerable<Aluno> alunos;
        public IndexModel(ILogger<IndexModel> logger, IAlunoRepository alunoRepository)
        {
            _logger = logger;
            _alunoRepository = alunoRepository;
        }

        public async Task OnGetAsync()
        {
            await _alunoRepository.PostAsync(new Aluno() { Id = 0, Nome = "Aluno" + DateTime.UtcNow.ToString(), Senha = "", Usuario = "" });

            alunos = await _alunoRepository.GetAllAsync();
        }
    }
}
