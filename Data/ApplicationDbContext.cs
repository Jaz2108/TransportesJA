using Microsoft.EntityFrameworkCore;
using TransportesJA.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<SolicitudTransporte> SolicitudesTransporte { get; set; }
    public DbSet<ConfirmacionReserva> ConfirmacionesReserva { get; set; }
    public DbSet<HistorialViaje> HistorialViajes { get; set; }
    public DbSet<PagoEnLinea> PagosEnLinea { get; set; }
    public DbSet<DescuentoPromocion> DescuentosYPromociones { get; set; }
    public DbSet<Notificacion> Notificaciones { get; set; }
    public DbSet<Chat> Chats { get; set; }
    public DbSet<Evaluacion> Evaluaciones { get; set; }
    public DbSet<SoporteEnLinea> SoporteEnLinea { get; set; }
}
