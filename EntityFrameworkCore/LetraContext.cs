using EntityFrameworkCore.Maps;
using EntityFrameworkCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore
{
    internal class LetraContext : DbContext
    {
        public virtual DbSet<LetraModel> Letra { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\eduar\source\repos\EntityFrameworkCore\EntityFrameworkCore\DB\Letras.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LetraMap());            
        }
    }
}
