using System.ComponentModel.DataAnnotations;

namespace BubbleBrainAPI.DTOs
{
    public class VideojuegoUpdateDTO : VideojuegoCreateDTO
    {
        [Required]
        public int Id { get; set; }
    }
}