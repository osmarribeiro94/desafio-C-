using Microsoft.AspNetCore.Mvc;
using challenge.Model;
using challenge.Repository;

namespace challenge.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TurmaController : ControllerBase
    {
        private readonly ITurmaRepository _repository;
        public TurmaController(ITurmaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var turmas = await _repository.BuscaTurmas();
            return turmas.Any() ? Ok(turmas) : NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> Post(Turma turma)
        {
            _repository.AdicionaTurma(turma);
            return await _repository.SaveChangesAsync() ? Ok("Turma adicionado com sucesso") : BadRequest("Erro ao salvar a turma.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var turma = await _repository.BuscaTurma(id);
            return turma != null ? Ok(turma) : NotFound("Turma não encontrado");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Turma turma)
        {
            var turmaBanco = await _repository.BuscaTurma(id);
            if (turmaBanco == null) return NotFound("Turma não encontrado");

            turmaBanco.Nome = turma.Nome ?? turmaBanco.Nome;
            // turmaBanco.Turno = turma.Turno == turmaBanco.Turno ? turmaBanco.Turno : turma.Turno;

            _repository.AtualizaTurma(turmaBanco);
            
            return await _repository.SaveChangesAsync() ? Ok("Turma atualizado com sucesso") : BadRequest("Erro ao atualizar a turma");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var turmaBanco = await _repository.BuscaTurma(id);
            if (turmaBanco == null) return NotFound("Turma não encontrado");

            _repository.DeletaTurma(turmaBanco);

            return await _repository.SaveChangesAsync() ? Ok("Turma deletado com sucesso") : BadRequest("Erro ao deletado a turma");
        }


    }
}