using Microsoft.AspNetCore.Mvc;

namespace UI.Endpoints
{
    [ApiController]
    [Route("api/aluno")]
    public class AlunoController : ControllerBase
    {
        [HttpPost]
        public ActionResult CreateAluno([FromBody] )
        {

        }
    }
}
