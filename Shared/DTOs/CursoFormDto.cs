using System.ComponentModel.DataAnnotations;

namespace Shared.DTOs;

public class CursoFormDto
{
    public int? Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio")]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "El código es obligatorio")]
    public string Codigo { get; set; } = string.Empty;

    [Range(1, 20, ErrorMessage = "Los créditos deben ser mayores que cero")]
    public int Creditos { get; set; }

    public bool Activo { get; set; } = true;
}