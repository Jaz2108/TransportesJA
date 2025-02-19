namespace TransportesJA.Models
{
    public class ConfirmacionReserva
    {
        public int Id { get; set; }
        public string Chofer { get; set; }
        public string TipoVehiculo { get; set; }
        public string Ubicacion { get; set; }
        public decimal Monto { get; set; }

        public int SolicitudId { get; set; }  // Asegurar que existe

        // Relación con SolicitudesTransporte
        public SolicitudTransporte Solicitud { get; set; }
    }
}
