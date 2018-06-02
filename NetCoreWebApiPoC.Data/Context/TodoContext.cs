using Microsoft.EntityFrameworkCore;
using NetCoreWebApiPoC.Domain;

namespace NetCoreWebApiPoC.Data.Context
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }
    }
}
