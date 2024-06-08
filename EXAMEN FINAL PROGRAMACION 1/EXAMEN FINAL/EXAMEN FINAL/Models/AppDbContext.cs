using System.Data.Entity;

public class AppDbContext : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Producto> Productos { get; set; }

    public AppDbContext() : base("name=MantenimientoProductos")
    {
    }
}

