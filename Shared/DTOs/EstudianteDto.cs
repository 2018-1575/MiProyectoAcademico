namespace Shared.DTOs
{
    public class EstudianteDto
    {
        public int Id { get; set; }

        public string NombreCompleto { get; set; } = string.Empty;

        public string Documento { get; set; } = string.Empty;

        public string Estado { get; set; } = string.Empty;
    }
}