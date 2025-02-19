namespace TransportesJA.Models
{
    public class Chat
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Mensaje { get; set; }
        public DateTime FechaHora { get; set; }
    }
}