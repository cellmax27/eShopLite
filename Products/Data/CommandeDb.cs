using DataEntities;
using Microsoft.EntityFrameworkCore;

class CommandeDb : DbContext
{
    public CommandeDb(DbContextOptions<CommandeDb> options)
        : base(options) { }

    public DbSet<Commande> Commandes => Set<Commande>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Commande>()
            .HasData(
            new Commande { Id = 1, Name = "Commande1", Instock = true },
            new Commande { Id = 2, Name = "Commande2", Instock = false },
            new Commande { Id = 3, Name = "Commande3", Instock = true }
            );
    }
}