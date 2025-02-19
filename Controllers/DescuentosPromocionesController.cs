using Microsoft.AspNetCore.Mvc;
using TransportesJA.DTOs;
using TransportesJA.Models;

namespace TransportesJA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DescuentosPromocionesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DescuentosPromocionesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DescuentoPromocionDTO>> GetDescuentosPromociones()
        {
            return _context.DescuentosYPromociones.Select(d => new DescuentoPromocionDTO
            {
                Id = d.Id,
                Mensaje = d.Mensaje,
                FechaInicio = d.FechaInicio,
                FechaFin = d.FechaFin
            }).ToList();
        }

        [HttpPost]
        public ActionResult<DescuentoPromocionDTO> CreateDescuentoPromocion(DescuentoPromocionDTO descuentoDto)
        {
            var descuento = new DescuentoPromocion
            {
                Mensaje = descuentoDto.Mensaje,
                FechaInicio = descuentoDto.FechaInicio,
                FechaFin = descuentoDto.FechaFin
            };

            _context.DescuentosYPromociones.Add(descuento);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetDescuentosPromociones), new { id = descuento.Id }, descuentoDto);
        }
    }
}
