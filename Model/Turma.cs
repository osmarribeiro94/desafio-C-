using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace challenge.Model
{
    public class Turma
    {
        [Key()]
        public int Id { get; set; }
        public String Nome { get; set; }

        [ForeignKey("Turno")]
        public int TurnoId { get; set; }
        public virtual Turno Turno { get; set; }
    }
}