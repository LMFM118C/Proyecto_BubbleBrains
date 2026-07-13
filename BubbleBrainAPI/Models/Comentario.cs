namespace BubbleBrainAPI.Models
{
    public class Comentario
    {
        public int Id { get; set; }

        public string? Texto { get; set; }

        public int VideojuegoId { get; set; }

        public Videojuego Videojuego { get; set; }

        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }
    }
}