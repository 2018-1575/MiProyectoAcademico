namespace Domain.Entities
{
    public class Matricula
    {
        public int Id { get; set; }

        public int EstudianteId { get; set; }

        public int CursoId { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}