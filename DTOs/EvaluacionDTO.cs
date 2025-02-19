using System;
using System.ComponentModel.DataAnnotations;

namespace TransportesJA.DTOs
{
    public class EvaluacionDTO
    {
        public int Id { get; set; }
        public string Comentarios { get; set; }

        [Required]
        [Range(1, 5)]
        public int Estrellas { get; set; }

        [Required]
        public int UsuarioId { get; set; }  // Verificar que esté correctamente definido

        public DateTime Fecha { get; set; }
    }
}
