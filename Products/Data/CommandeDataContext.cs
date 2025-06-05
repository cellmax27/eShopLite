using DataEntities;
using Microsoft.EntityFrameworkCore;

namespace Commandes.Data;

public sealed class CommandeDataContext(DbContextOptions<CommandeDataContext> options)
    : DbContext(options)
{
    public DbSet<Commande> Commande { get; set; } = default!;

    internal async Task SaveChangesAsync()
    {
        throw new NotImplementedException();
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
            new() { Name = "Solar Powered Flashlight", Description = "A fantastic commande for outdoor enthusiasts", Price = 19.99m, ImageUrl = "commande1.png" },
            new() { Name = "Hiking Poles", Description = "Ideal for camping and hiking trips", Price = 24.99m, ImageUrl = "commande2.png" },
            new() { Name = "Outdoor Rain Jacket", Description = "This commande will keep you warm and dry in all weathers", Price = 49.99m, ImageUrl = "commande3.png" },
            new() { Name = "Survival Kit", Description = "A must-have for any outdoor adventurer", Price = 99.99m, ImageUrl = "commande4.png" },
            new() { Name = "Outdoor Backpack", Description = "This backpack is perfect for carrying all your outdoor essentials", Price = 39.99m, ImageUrl = "commande5.png" },
            new() { Name = "Camping Cookware", Description = "This cookware set is ideal for cooking outdoors", Price = 29.99m, ImageUrl = "commande6.png" },
            new() { Name = "Camping Stove", Description = "This stove is perfect for cooking outdoors", Price = 49.99m, ImageUrl = "commande7.png" },
            new() { Name = "Camping Lantern", Description = "This lantern is perfect for lighting up your campsite", Price = 19.99m, ImageUrl = "commande8.png" },
            new() { Name = "Camping Tent", Description = "This tent is perfect for camping trips", Price = 99.99m, ImageUrl = "commande9.png" },
        };

        context.AddRange(commandes);

        context.SaveChanges();
    }
}
