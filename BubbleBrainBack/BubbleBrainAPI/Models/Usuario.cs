namespace BubbleBrainAPI.Models

{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public List<Videojuego> Favoritos { get; set; }
            = new();
    }
}