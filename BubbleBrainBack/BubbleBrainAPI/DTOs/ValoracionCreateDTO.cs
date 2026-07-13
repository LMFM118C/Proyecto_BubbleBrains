using System.ComponentModel.DataAnnotations;

namespace BubbleBrainAPI.DTOs
{
    public class ValoracionCreateDTO
    {
        [Range(1, 5, ErrorMessage = "La nota debe estar entre {1} y {2}")]
        public int Nota { get; set; }
    }
}