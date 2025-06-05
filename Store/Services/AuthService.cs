using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class AuthService
{
    private readonly UserDb _db;

    public class UserDb : DbContext
    {
        public UserDb(DbContextOptions<UserDb> options)
            : base(options)
        {
            Users = Set<DataEntities.User>();
        }

        public DbSet<DataEntities.User> Users;

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
    }

    public async Task<DataEntities.User?> AuthenticateAsync(string name, string password)
    {
        return await _db.Users
            .FirstOrDefaultAsync(u => u.Name == name && u.Password == password);
    }
}
