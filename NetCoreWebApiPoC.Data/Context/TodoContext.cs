using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NetCoreWebApiPoC.Domain;

namespace NetCoreWebApiPoC.Data.Context
{
    public class ITodoContext : IdentityDbContext<ApplicationUser>, ITodoContext
    {
        public ITodoContext(DbContextOptions<ITodoContext> options) : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }
    }

    interface ITodoContext
    {
        DbSet<Todo> Todos { get; set; }
        int SaveChanges();
    }

    public static class DbInitializer
    {
        public static void Initialize(ITodoContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
