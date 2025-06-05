using DataEntities;
using Microsoft.EntityFrameworkCore;

class UserDb : DbContext
{
    public UserDb(DbContextOptions<UserDb> options)
        : base(options) { }

    public DbSet<User> Users => Set<User>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>()
            .HasData(
            new User { Id = 1, Name = "Jean", LastName="", Email="", Adresse = "", Phone="" },
            new User { Id = 2, Name = "Paul", LastName = "", Email = "", Adresse = "", Phone = "" },
            new User { Id = 3, Name = "Pierre", LastName = "", Email = "", Adresse = "", Phone = "" }
            );
    }
}