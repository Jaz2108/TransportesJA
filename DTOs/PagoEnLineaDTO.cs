using System;

namespace TransportesJA.DTOs
{
    public class PagoEnLineaDTO
    {
        public int Id { get; set; }
        public string NombreTitular { get; set; }
        public string NumeroTarjeta { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public string CodigoSeguridad { get; set; }
        public decimal Monto { get; set; }
        public int UsuarioId { get; set; } // Agregado
    }
}
