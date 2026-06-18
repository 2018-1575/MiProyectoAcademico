namespace Domain.Entities;

public class Curso
{
    public int Id { get; set; }

    public string Nombre { get; set; } = string.Empty;

    public string Codigo { get; set; } = string.Empty;

    public int Creditos { get; set; }

    public bool Activo { get; set; }
}