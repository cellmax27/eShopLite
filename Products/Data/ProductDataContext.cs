using DataEntities;
using Microsoft.EntityFrameworkCore;

namespace Products.Data;

public sealed class ProductDataContext(DbContextOptions<ProductDataContext> options)
    : DbContext(options)
{
    public DbSet<Product> Product { get; set; } = default!;

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
        var context = services.GetRequiredService<ProductDataContext>();
        context.Database.EnsureCreated();
        DbInitializer.Initialize(context);
    }
}

public static class DbInitializer
{
    public static void Initialize(ProductDataContext context)
    {
        if (context.Product.Any())
            return;

        var products = new List<Product>
        {
            new() { Name = "Solar Powered Flashlight", Description = "A fantastic product for outdoor enthusiasts", Price = 19.99m, ImageUrl = "product1.png" },
            new() { Name = "Hiking Poles", Description = "Ideal for camping and hiking trips", Price = 24.99m, ImageUrl = "product2.png" },
            new() { Name = "Outdoor Rain Jacket", Description = "This product will keep you warm and dry in all weathers", Price = 49.99m, ImageUrl = "product3.png" },
            new() { Name = "Survival Kit", Description = "A must-have for any outdoor adventurer", Price = 99.99m, ImageUrl = "product4.png" },
            new() { Name = "Outdoor Backpack", Description = "This backpack is perfect for carrying all your outdoor essentials", Price = 39.99m, ImageUrl = "product5.png" },
            new() { Name = "Camping Cookware", Description = "This cookware set is ideal for cooking outdoors", Price = 29.99m, ImageUrl = "product6.png" },
            new() { Name = "Camping Stove", Description = "This stove is perfect for cooking outdoors", Price = 49.99m, ImageUrl = "product7.png" },
            new() { Name = "Camping Lantern", Description = "This lantern is perfect for lighting up your campsite", Price = 19.99m, ImageUrl = "product8.png" },
            new() { Name = "Camping Tent", Description = "This tent is perfect for camping trips", Price = 99.99m, ImageUrl = "product9.png" },
        };

        context.AddRange(products);

        //if (context.Commande.Any())
          //  return;

        var commandes = new List<Commande>
        {
            new Commande { Id = 1, Name = "Commande1", Instock = true },
            new Commande { Id = 2, Name = "Commande2", Instock = false },
            new Commande { Id = 3, Name = "Commande3", Instock = true }
        };

        context.AddRange(commandes);


        //if (context.User.Any())
          //  return;

        var users = new List<User>
        {
            new User { Id = 1, Name = "Jean", LastName="", Email="", Adresse = "", Phone="" },
            new User { Id = 2, Name = "Paul", LastName = "", Email = "", Adresse = "", Phone = "" },
            new User { Id = 3, Name = "Pierre", LastName = "", Email = "", Adresse = "", Phone = "" }
        };

        context.AddRange(users);


        context.SaveChanges();
    }
}
