using EjemploEnClase.Model;
using Microsoft.EntityFrameworkCore;

namespace EjemploEnClase.DataContextFd
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        //public DbSet<Region> Region { get; set; }

        public DbSet<Employees> Employees { get; set; }
    }
}
