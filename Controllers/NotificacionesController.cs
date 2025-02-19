using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TransportesJA.DTOs;
using TransportesJA.Models;

namespace TransportesJA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificacionesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public NotificacionesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<NotificacionDTO>> GetNotificaciones()
        {
            return _context.Notificaciones.Select(n => new NotificacionDTO
            {
                Id = n.Id,
                Mensaje = n.Mensaje,
                UsuarioId = n.UsuarioId,
                FechaHora = n.FechaHora
            }).ToList();
        }

        [HttpPost]
        public ActionResult<NotificacionDTO> CreateNotificacion(NotificacionDTO notificacionDto)
        {
            var notificacion = new Notificacion
            {
                Mensaje = notificacionDto.Mensaje,
                UsuarioId = notificacionDto.UsuarioId,
                FechaHora = notificacionDto.FechaHora
            };

            _context.Notificaciones.Add(notificacion);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetNotificaciones), new { id = notificacion.Id }, notificacionDto);
        }
    }
}
