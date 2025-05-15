using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Producto> Productos { get; set; }

    public DbSet<Pedido> Pedidos {get; set;}
    public DbSet<PedidoDetalle> PedidoDetalles {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=infobar.db");
    }
}
