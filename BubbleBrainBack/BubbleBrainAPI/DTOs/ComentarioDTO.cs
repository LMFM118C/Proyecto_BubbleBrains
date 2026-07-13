namespace BubbleBrainAPI.DTOs
{
    public class ComentarioDTO
    {
        public int Id { get; set; }

        public string Texto { get; set; }

        public int VideojuegoId { get; set; }

        public int UsuarioId { get; set; }

        public string UsuarioNombre { get; set; }
    }
}
