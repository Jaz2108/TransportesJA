using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TransportesJA.DTOs;
using TransportesJA.Models;

namespace TransportesJA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfirmacionesReservaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ConfirmacionesReservaController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ConfirmacionReservaDTO>> GetConfirmaciones()
        {
            return _context.ConfirmacionesReserva.Select(c => new ConfirmacionReservaDTO
            {
                Id = c.Id,
                Chofer = c.Chofer,
                TipoVehiculo = c.TipoVehiculo,
                Ubicacion = c.Ubicacion,
                Monto = c.Monto,
                SolicitudId = c.SolicitudId
            }).ToList();
        }

        [HttpPost]
        public ActionResult<ConfirmacionReservaDTO> CreateConfirmacion(ConfirmacionReservaDTO confirmacionDto)
        {
            var confirmacion = new ConfirmacionReserva
            {
                Chofer = confirmacionDto.Chofer,
                TipoVehiculo = confirmacionDto.TipoVehiculo,
                Ubicacion = confirmacionDto.Ubicacion,
                Monto = confirmacionDto.Monto,
                SolicitudId = confirmacionDto.SolicitudId
            };

            _context.ConfirmacionesReserva.Add(confirmacion);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetConfirmaciones), new { id = confirmacion.Id }, confirmacionDto);
        }
    }
}
