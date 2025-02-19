using System;

namespace TransportesJA.Models
{
    public class PagoEnLinea
    {
        public int Id { get; set; }
        public string NombreTitular { get; set; }
        public string NumeroTarjeta { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public string CodigoSeguridad { get; set; }
        public decimal Monto { get; set; }
        public int UsuarioId { get; set; } // Agregado

        // Relación con Usuario
        public Usuario Usuario { get; set; }
    }
}
