namespace challenge.Model
{
    public class Chamada
    {
        public int id {get;set;}
        public int idAluno {get; set;}
        public int idTurma {get; set;}

        public DateTime data {get; set;}
        public Boolean presenca {get; set;}
    }
}