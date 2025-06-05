using DataEntities;
using Microsoft.EntityFrameworkCore;

namespace Commandes.Data;

public sealed class CommandeDataContext(DbContextOptions<CommandeDataContext> options)
    : DbContext(options)
{
    public DbSet<Commande> Commande { get; set; } = default!;

    internal async Task SaveChangesAsync()
    {
        await base.SaveChangesAsync();
    }
}

public static class Extensions
{
    public static void CreateDbIfNotExists(this IHost host)
    {
        using var scope = host.Services.CreateScope();

        var services = scope.ServiceProvider;
        var context = services.GetRequiredService<CommandeDataContext>();
        context.Database.EnsureCreated();
        DbInitializer.Initialize(context);
    }
}

public static class DbInitializer
{
    public static void Initialize(CommandeDataContext context)
    {
        if (context.Commande.Any())
            return;

        var commandes = new List<Commande>
        {
            new Commande { Id = 1, Name = "Commande1", Instock = true },
            new Commande { Id = 2, Name = "Commande2", Instock = false },
            new Commande { Id = 3, Name = "Commande3", Instock = true }
        };

        context.AddRange(commandes);

        context.SaveChanges();
    }
}
