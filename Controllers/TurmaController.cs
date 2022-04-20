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
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var turma = await _repository.BuscaTurma(id);
            return turma != null ? Ok(turma) : NotFound("Aluno não encontrado");
        }
        // [HttpPost]
        // public async Task<IActionResult> Post(Aluno aluno)
        // {
        //     _repository.AdicionaAluno(aluno);
        //     return await _repository.SaveChangesAsync() ? Ok("Aluno adicionado com sucesso") : BadRequest("Erro ao salvar o aluno.");
        // }

        // [HttpPut("{id}")]
        // public async Task<IActionResult> Put(int id, Aluno aluno)
        // {
        //     var alunoBanco = await _repository.BuscaAluno(id);
        //     if (alunoBanco == null) return NotFound("Aluno não encontrado");

        //     alunoBanco.Nome = aluno.Nome ?? alunoBanco.Nome;
        //     alunoBanco.Matricula = aluno.Matricula ?? alunoBanco.Matricula;
        //     alunoBanco.DtNascimento = aluno.DtNascimento != new DateTime() ? aluno.DtNascimento : alunoBanco.DtNascimento;

        //     _repository.AtualizaAluno(alunoBanco);

        //     return await _repository.SaveChangesAsync() ? Ok("Aluno atualizado com sucesso") : BadRequest("Erro ao atualizar o aluno");
        // }

        // [HttpDelete("{id}")]
        // public async Task<IActionResult> Delete(int id)
        // {
        //     var alunoBanco = await _repository.BuscaAluno(id);
        //     if (alunoBanco == null) return NotFound("Aluno não encontrado");

        //     _repository.DeletaAluno(alunoBanco);

        //     return await _repository.SaveChangesAsync() ? Ok("Aluno deletado com sucesso") : BadRequest("Erro ao deletado o aluno");
        // }
       

    }
}