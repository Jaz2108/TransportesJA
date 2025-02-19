using Microsoft.AspNetCore.Mvc;
using TransportesJA.DTOs;
using TransportesJA.Models;

namespace TransportesJA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UsuarioDTO>> GetUsuarios()
        {
            return _context.Usuarios.Select(u => new UsuarioDTO
            {
                Id = u.Id,
                Cedula = u.Cedula,
                Nombre = u.Nombre,
                Apellido = u.Apellido,
                Email = u.Email
            }).ToList(); // Eliminado FechaRegistro
        }

        [HttpPost("register")]
        public ActionResult<UsuarioDTO> Register(UsuarioDTO usuarioDto)
        {
            var usuario = new Usuario
            {
                Cedula = usuarioDto.Cedula,
                Nombre = usuarioDto.Nombre,
                Apellido = usuarioDto.Apellido,
                Email = usuarioDto.Email,
                Password = usuarioDto.Password, // Debes encriptarla antes de guardarla
                FechaRegistro = DateTime.Now // Se asigna automáticamente
            };

            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetUsuarios), new { id = usuario.Id }, usuarioDto);
        }
    }
    
}
