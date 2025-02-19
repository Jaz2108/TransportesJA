namespace TransportesJA.DTOs
{
    public class SoporteEnLineaDTO
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; } // Agregado
        public string Mensaje { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
