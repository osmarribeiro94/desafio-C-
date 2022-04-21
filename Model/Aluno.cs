namespace challenge.Model
{
    public class Aluno
    {
        public int Id { get; set; }
        public String Matricula { get; set; }
        public String Nome { get; set; }
        public DateTime DtNascimento { get; set; }

        public virtual Turma Turmas {get; set;}

    }
}