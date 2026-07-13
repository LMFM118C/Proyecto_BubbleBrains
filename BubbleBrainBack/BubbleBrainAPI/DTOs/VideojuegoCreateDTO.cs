using System.ComponentModel.DataAnnotations;
using BubbleBrainAPI.Models;

namespace BubbleBrainAPI.DTOs
{
    public class VideojuegoCreateDTO
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(150)]
        public string Titulo { get; set; }

        [StringLength(1000)]
        public string Descripcion { get; set; }

        [Range(1970, 2030, ErrorMessage = "El {0} no es válido")]
        public int AnyoSalida { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(50)]
        public string Genero { get; set; }

        [Url(ErrorMessage = "El campo {0} debe ser una URL válida")]
        public string Caratula { get; set; }

        [Url(ErrorMessage = "El campo {0} debe ser una URL válida")]
        public string Trailer { get; set; }

        [Required(ErrorMessage = "Debes indicar la desarrolladora")]
        public int DesarrolladoraId { get; set; }

        [Required(ErrorMessage = "Debes indicar al menos una plataforma")]
        [MinLength(1, ErrorMessage = "Debes indicar al menos una plataforma")]
        public List<Plataformas> Plataformas { get; set; } = new();
    }
}
