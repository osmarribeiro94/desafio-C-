using Microsoft.AspNetCore.Mvc;
using challenge.Model;
using challenge.DTO;
using challenge.Repository;

namespace challenge.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoRepository _repository;
        private readonly ITurmaRepository _turmaRepository;
        public AlunoController(IAlunoRepository repository, ITurmaRepository turmaRepository)
        {
            _repository = repository;
            _turmaRepository = turmaRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var alunos = await _repository.BuscaAlunos();
            return alunos.Any() ? Ok(alunos) : NoContent();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var aluno = await _repository.BuscaAluno(id);
            return aluno != null ? Ok(aluno) : NotFound("Aluno não encontrado");
        }

        [HttpGet("turma-id/{turmaId}")]
        public async Task<IActionResult> GetByTurmaId(int turmaId)
        {
            var alunos = await _repository.BuscaAlunosByTurmaId(turmaId);
            return alunos != null ? Ok(alunos) : NotFound("Aluno não encontrado");
        }
        [HttpPost]
        public async Task<IActionResult> Post(AlunoDTO newAluno)
        {
            var aluno = new Aluno();
            aluno.Matricula = newAluno.Matricula;
            aluno.Nome = newAluno.Nome;
            aluno.Turmas = await _turmaRepository.BuscaTurma(newAluno.TurmaId);
            _repository.AdicionaAluno(aluno);
            return await _repository.SaveChangesAsync() ? Ok("Aluno adicionado com sucesso") : BadRequest("Erro ao salvar o aluno.");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Aluno aluno)
        {
            var alunoBanco = await _repository.BuscaAluno(id);
            if (alunoBanco == null) return NotFound("Aluno não encontrado");

            alunoBanco.Nome = aluno.Nome ?? alunoBanco.Nome;
            alunoBanco.Matricula = aluno.Matricula ?? alunoBanco.Matricula;
            alunoBanco.DtNascimento = aluno.DtNascimento != new DateTime() ? aluno.DtNascimento : alunoBanco.DtNascimento;

            _repository.AtualizaAluno(alunoBanco);

            return await _repository.SaveChangesAsync() ? Ok("Aluno atualizado com sucesso") : BadRequest("Erro ao atualizar o aluno");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var alunoBanco = await _repository.BuscaAluno(id);
            if (alunoBanco == null) return NotFound("Aluno não encontrado");

            _repository.DeletaAluno(alunoBanco);

            return await _repository.SaveChangesAsync() ? Ok("Aluno deletado com sucesso") : BadRequest("Erro ao deletado o aluno");
        }

    }
}