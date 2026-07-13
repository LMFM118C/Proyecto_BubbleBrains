using System.ComponentModel.DataAnnotations;

namespace BubbleBrainAPI.DTOs
{
    public class UsuarioCreateDTO
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [EmailAddress(ErrorMessage = "El {0} no tiene un formato válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "La contraseña debe tener al menos {2} caracteres")]
        public string Password { get; set; }
    }
}
