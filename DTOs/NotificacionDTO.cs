using System;

namespace TransportesJA.DTOs
{
    public class NotificacionDTO
    {
        public int Id { get; set; }
        public string Mensaje { get; set; }
        public int UsuarioId { get; set; } // Asegurar que está incluido
        public DateTime FechaHora { get; set; }
    }
}
