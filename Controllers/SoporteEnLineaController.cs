using Microsoft.AspNetCore.Mvc;
using TransportesJA.DTOs;
using TransportesJA.Models;

namespace TransportesJA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoporteEnLineaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SoporteEnLineaController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<SoporteEnLineaDTO>> GetSoportes()
        {
            return _context.SoporteEnLinea.Select(s => new SoporteEnLineaDTO
            {
                Id = s.Id,
                UsuarioId = s.UsuarioId,
                Mensaje = s.Mensaje,
                FechaHora = s.FechaHora
            }).ToList();
        }

        [HttpPost]
        public ActionResult<SoporteEnLineaDTO> CreateSoporte(SoporteEnLineaDTO soporteDto)
        {
            var soporte = new SoporteEnLinea
            {
                UsuarioId = soporteDto.UsuarioId,
                Mensaje = soporteDto.Mensaje,
                FechaHora = soporteDto.FechaHora
            };

            _context.SoporteEnLinea.Add(soporte);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetSoportes), new { id = soporte.Id }, soporteDto);
        }
    }
}
