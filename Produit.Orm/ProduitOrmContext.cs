using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Produit.Orm
{
    public class ProduitOrmContext : DbContext
    {
        public ProduitOrmContext()
        {}

        public ProduitOrmContext(DbContextOptions<ProduitOrmContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Product> Produits { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer("Server=localhost,1450;Database=ProduitV2;User Id=SA;Password=Password123456789;Encrypt=True;TrustServerCertificate=True")
                    .LogTo(message => Debug.WriteLine(message));
            }
        }
    }
}