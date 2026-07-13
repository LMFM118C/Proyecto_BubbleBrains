using System.ComponentModel.DataAnnotations;

namespace BubbleBrainAPI.DTOs
{
    public class ComentarioCreateDTO
    {
        [Required(ErrorMessage = "El comentario no puede estar vacío")]
        [StringLength(500, ErrorMessage = "El comentario no puede superar los {1} caracteres")]
        public string Texto { get; set; }
    }
}
