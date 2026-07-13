using BubbleBrainAPI.Models;

namespace BubbleBrainAPI.DTOs
{
    public class VideojuegoDTO
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

        public string DesarrolladoraNombre { get; set; }

        public List<Plataformas> Plataformas { get; set; } = new();
    }
}