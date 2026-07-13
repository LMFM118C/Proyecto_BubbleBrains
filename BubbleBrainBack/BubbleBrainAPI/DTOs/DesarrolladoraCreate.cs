using System.ComponentModel.DataAnnotations;

namespace BubbleBrainAPI.DTOs
{
    public class DesarrolladoraCreateDTO
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Range(1950, 2030, ErrorMessage = "El {0} no es válido")]
        public int AnyoFundacion { get; set; }

        [Url(ErrorMessage = "El campo {0} debe ser una URL válida")]
        public string Logo { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(60)]
        public string Pais { get; set; }
    }
}
