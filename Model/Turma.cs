using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using challenge.Data;

namespace challenge.Model
{
    public class Turma
    {
        
        public int Id { get; set; }
        public String Nome { get; set; }

        public virtual Turno Turnos {get; set;}

    }
}