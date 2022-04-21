using Microsoft.AspNetCore.Mvc;
using challenge.Model;
using challenge.Repository;
using challenge.DTO;
namespace challenge.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChamadaController : ControllerBase
    {
        private readonly IChamadaRepository _repository;
        private readonly ITurmaRepository _turmaRepository;
        private readonly IAlunoRepository _alunoRepository;
        public ChamadaController(IChamadaRepository repository, ITurmaRepository turmaRepository, IAlunoRepository alunoRepository)
        {
            _repository = repository;
            _turmaRepository = turmaRepository;
            _alunoRepository = alunoRepository;
        }

        [HttpPost("registrar-presenca")]
        public async Task<IActionResult> Post(ChamadaDTO newChamada)
        {
            var aluno = await _alunoRepository.BuscaAluno(newChamada.idAluno);

            if (aluno != null)
            {
                var chamada = new Chamada();
                chamada.idAluno = aluno.Id;
                chamada.idTurma = aluno.Turmas.Id;
                chamada.data = newChamada.data;
                chamada.presenca = newChamada.stPresente;

                _repository.registraPresenca(chamada);
                return await _repository.SaveChangesAsync() ? Ok("Chamada registrada com sucesso") : BadRequest("Erro ao registrar chamada.");
            }
            else
            {
                return BadRequest("Erro ao registrar chamada.");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var chamadas = _repository.buscaChamadas();
            return chamadas.Any() ? Ok(chamadas) : NoContent();
        }
    }
}