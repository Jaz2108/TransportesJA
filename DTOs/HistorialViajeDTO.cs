using System;

namespace TransportesJA.DTOs
{
    public class HistorialViajeDTO
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Ubicacion { get; set; }
        public decimal Monto { get; set; }
        public int UsuarioId { get; set; } // Verificar que esté correctamente definido
    }
}

