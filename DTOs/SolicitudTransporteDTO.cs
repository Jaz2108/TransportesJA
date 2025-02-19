namespace TransportesJA.DTOs
{
    public class SolicitudTransporteDTO
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Ubicacion { get; set; }
        public string TipoVehiculo { get; set; }
        public string TipoPago { get; set; }
        public int UsuarioId { get; set; } // Agregado
    }
}
