using DataEntities;
using Microsoft.EntityFrameworkCore;

namespace Users.Data;

public sealed class UserDataContext(DbContextOptions<UserDataContext> options)
    : DbContext(options)
{
    public DbSet<User> User { get; set; } = default!;

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
        var context = services.GetRequiredService<UserDataContext>();
        context.Database.EnsureCreated();
        DbInitializer.Initialize(context);
    }
}

public static class DbInitializer
{
    public static void Initialize(UserDataContext context)
    {
        if (context.User.Any())
            return;

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
