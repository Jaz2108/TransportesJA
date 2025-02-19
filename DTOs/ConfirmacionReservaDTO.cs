using System;
using System.ComponentModel.DataAnnotations;

namespace TransportesJA.DTOs
{
    public class ConfirmacionReservaDTO
    {
        public int Id { get; set; }

        [Required]
        public string Chofer { get; set; }

        [Required]
        public string TipoVehiculo { get; set; }

        [Required]
        public string Ubicacion { get; set; }

        [Required]
        public decimal Monto { get; set; }

        [Required]
        public int SolicitudId { get; set; }  // Asegurar que esté correctamente definido
    }
}
