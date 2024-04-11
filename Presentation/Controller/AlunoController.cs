using Microsoft.AspNetCore.Mvc;

namespace DotNetDesafio.Presentation.Controller
{
    [ApiController]
    [Route("api/aluno")]
    public class AlunoController : ControllerBase
    {
        [HttpPost]
        public ActionResult CreateAluno()
        {
            return Ok();
        }
    }
}
