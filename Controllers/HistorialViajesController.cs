using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TransportesJA.DTOs;
using TransportesJA.Models;

namespace TransportesJA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistorialViajesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public HistorialViajesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<HistorialViajeDTO>> GetHistorialViajes()
        {
            return _context.HistorialViajes.Select(h => new HistorialViajeDTO
            {
                Id = h.Id,
                Fecha = h.Fecha,
                Hora = h.Hora,
                Ubicacion = h.Ubicacion,
                Monto = h.Monto,
                UsuarioId = h.UsuarioId
            }).ToList();
        }

        [HttpPost]
        public ActionResult<HistorialViajeDTO> CreateHistorialViaje(HistorialViajeDTO historialDto)
        {
            var historial = new HistorialViaje
            {
                Fecha = historialDto.Fecha,
                Hora = historialDto.Hora,
                Ubicacion = historialDto.Ubicacion,
                Monto = historialDto.Monto,
                UsuarioId = historialDto.UsuarioId
            };

            _context.HistorialViajes.Add(historial);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetHistorialViajes), new { id = historial.Id }, historialDto);
        }
    }
}
