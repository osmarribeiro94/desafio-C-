using System.ComponentModel.DataAnnotations;
using challenge.Data;

namespace challenge.Model
{
    public class Turno
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public List<Turma> Turmas {get; set;}
    }
}