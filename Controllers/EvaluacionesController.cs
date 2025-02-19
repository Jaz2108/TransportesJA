using Microsoft.AspNetCore.Mvc;
using TransportesJA.DTOs;
using TransportesJA.Models;

namespace TransportesJA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EvaluacionesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EvaluacionesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<EvaluacionDTO>> GetEvaluaciones()
        {
            return _context.Evaluaciones.Select(e => new EvaluacionDTO
            {
                Id = e.Id,
                Comentarios = e.Comentarios,
                Estrellas = e.Estrellas,
                UsuarioId = e.UsuarioId,
                Fecha = e.Fecha
            }).ToList();
        }

        [HttpPost]
        public ActionResult<EvaluacionDTO> CreateEvaluacion(EvaluacionDTO evaluacionDto)
        {
            var evaluacion = new Evaluacion
            {
                Comentarios = evaluacionDto.Comentarios,
                Estrellas = evaluacionDto.Estrellas,
                UsuarioId = evaluacionDto.UsuarioId,
                Fecha = evaluacionDto.Fecha
            };

            _context.Evaluaciones.Add(evaluacion);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetEvaluaciones), new { id = evaluacion.Id }, evaluacionDto);
        }
    }
}
