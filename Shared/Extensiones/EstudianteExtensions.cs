using Shared.DTOs;
using Domain.Entities;
using Domain.Enums; 

namespace Shared.Extensions
{
    public static class EstudianteExtensions
    {
        public static EstudianteDto ToDto(this Estudiante estudiante)
        {
            return new EstudianteDto
            {
                Id = estudiante.Id,
                NombreCompleto =
                    $"{estudiante.Nombre} {estudiante.Apellido}",

                Documento = estudiante.Documento,

                Estado = estudiante.Estado.ToString()
            };
        }
    }
}
