using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using NetCoreWebApiPoC.Domain.Entities;

namespace NetCoreWebApiPoc.Persistence
{
    public class TodoContext : IdentityDbContext<ApplicationUser>, ITodoContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }
    }

    public interface ITodoContext
    {
        DbSet<Todo> Todos { get; set; }
        int SaveChanges();
        DatabaseFacade Database { get; }
    }

    public static class DbInitializer
    {
        public static void Initialize(ITodoContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
