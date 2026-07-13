namespace BubbleBrainAPI.Models
{
    public class Valoracion
    {
        public int Id { get; set; }

        public int Nota { get; set; }

        public int VideojuegoId { get; set; }

        public Videojuego Videojuego { get; set; }

        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }
    }
}