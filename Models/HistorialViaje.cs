using System;

namespace TransportesJA.Models
{
    public class HistorialViaje
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Ubicacion { get; set; }
        public decimal Monto { get; set; }

        public int UsuarioId { get; set; } // Asegurar que existe

        // Relación con Usuario
        public Usuario Usuario { get; set; }
    }
}
