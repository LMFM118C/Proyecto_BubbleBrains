namespace BubbleBrainAPI.Models
{
    public class VideojuegoPlataforma
    {
        public int VideojuegoId { get; set; }
 
        public Videojuego Videojuego { get; set; }
 
        public Plataformas Plataforma { get; set; }
    }
}