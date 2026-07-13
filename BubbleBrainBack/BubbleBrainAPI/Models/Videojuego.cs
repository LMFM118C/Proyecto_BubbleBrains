namespace BubbleBrainAPI.Models
{
    public class Videojuego
    {
        public int Id { get; set; }
 
        public string Titulo { get; set; }
 
        public string Descripcion { get; set; }
 
        public int AnyoSalida { get; set; }
 
        public string Genero { get; set; }
 
        public string Caratula { get; set; }
 
        public string Trailer { get; set; }
 
        public double ValMedia { get; set; }
 
        public int DesarrolladoraId { get; set; }
 
        public Desarrolladora Desarrolladora { get; set; }
 
        public List<VideojuegoPlataforma> VideojuegoPlataformas { get; set; } = new();
    }
}