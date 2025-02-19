using System;

namespace TransportesJA.Models
{
    public class Notificacion
    {
        public int Id { get; set; }
        public string Mensaje { get; set; }
        public int UsuarioId { get; set; } // Debe estar presente

        public DateTime FechaHora { get; set; } = DateTime.Now;

        // Relación con Usuario
        public Usuario Usuario { get; set; }
    }
}
