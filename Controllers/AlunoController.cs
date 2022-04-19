using Microsoft.AspNetCore.Mvc;
using challenge.Model;

namespace challenge.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private static List<Aluno> Alunos()
        {
            return new List<Aluno>{
                new Aluno{Nome="Lucas", Id=1, Matricula= "1", DtNascimento = new DateTime()}
        };
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos());
        }
        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            var alunos = Alunos();
            alunos.Add(aluno);
            return Ok(alunos);
        }

    }
}