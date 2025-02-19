using System;

namespace TransportesJA.Models
{
    public class Evaluacion
    {
        public int Id { get; set; }
        public string Comentarios { get; set; }
        public int Estrellas { get; set; }

        public int UsuarioId { get; set; }  // Asegurar que existe

        // Relación con Usuario
        public Usuario Usuario { get; set; }

        public DateTime Fecha { get; set; }
    }
}
