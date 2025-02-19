using Microsoft.AspNetCore.Mvc;
using TransportesJA.DTOs;
using TransportesJA.Models;

namespace TransportesJA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitudesTransporteController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SolicitudesTransporteController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<SolicitudTransporteDTO>> GetSolicitudes()
        {
            return _context.SolicitudesTransporte.Select(s => new SolicitudTransporteDTO
            {
                Id = s.Id,
                Fecha = s.Fecha,
                Hora = s.Hora,
                Ubicacion = s.Ubicacion,
                TipoVehiculo = s.TipoVehiculo,
                TipoPago = s.TipoPago,
                UsuarioId = s.UsuarioId
            }).ToList();
        }

        [HttpPost]
        public ActionResult<SolicitudTransporteDTO> CreateSolicitud(SolicitudTransporteDTO solicitudDto)
        {
            var solicitud = new SolicitudTransporte
            {
                Fecha = solicitudDto.Fecha,
                Hora = solicitudDto.Hora,
                Ubicacion = solicitudDto.Ubicacion,
                TipoVehiculo = solicitudDto.TipoVehiculo,
                TipoPago = solicitudDto.TipoPago,
                UsuarioId = solicitudDto.UsuarioId
            };

            _context.SolicitudesTransporte.Add(solicitud);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetSolicitudes), new { id = solicitud.Id }, solicitudDto);
        }
    }
}
