using Microsoft.EntityFrameworkCore;
using MigrationsProject.Models;

namespace MigrationsProject.Context
{
    public class MyContext : DbContext
    {
        public DbSet<FooBar> FooBars { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }
    }
}