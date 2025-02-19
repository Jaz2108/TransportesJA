using Microsoft.AspNetCore.Mvc;
using TransportesJA.DTOs;
using TransportesJA.Models;

namespace TransportesJA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagosEnLineaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PagosEnLineaController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PagoEnLineaDTO>> GetPagos()
        {
            return _context.PagosEnLinea.Select(p => new PagoEnLineaDTO
            {
                Id = p.Id,
                NombreTitular = p.NombreTitular,
                NumeroTarjeta = p.NumeroTarjeta,
                FechaExpiracion = p.FechaExpiracion,
                CodigoSeguridad = p.CodigoSeguridad,
                Monto = p.Monto,
                UsuarioId = p.UsuarioId
            }).ToList();
        }

        [HttpPost]
        public ActionResult<PagoEnLineaDTO> CreatePago(PagoEnLineaDTO pagoDto)
        {
            var pago = new PagoEnLinea
            {
                NombreTitular = pagoDto.NombreTitular,
                NumeroTarjeta = pagoDto.NumeroTarjeta,
                FechaExpiracion = pagoDto.FechaExpiracion,
                CodigoSeguridad = pagoDto.CodigoSeguridad,
                Monto = pagoDto.Monto,
                UsuarioId = pagoDto.UsuarioId
            };

            _context.PagosEnLinea.Add(pago);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetPagos), new { id = pago.Id }, pagoDto);
        }
    }
}
