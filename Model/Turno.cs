using System.ComponentModel.DataAnnotations;

namespace challenge.Model
{
    public class Turno
    {
        [Key()]
        public int Id { get; set; }
        public String Nome { get; set; }
    }
}