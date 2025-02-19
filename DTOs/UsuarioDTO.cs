namespace TransportesJA.DTOs
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // Agregado
        public DateTime FechaRegistro { get; set; } // Agregado
    }
}
