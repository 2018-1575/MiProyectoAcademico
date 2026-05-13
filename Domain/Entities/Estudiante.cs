using Domain.Enums;

namespace Domain.Entities
{
    public class Estudiante
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Apellido { get; set; } = string.Empty;

        public string Documento { get; set; } = string.Empty;

        public EstadoEstudiante Estado { get; set; }
    }
}