using Projet_hespel_bryan.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Projet_hespel_bryan.dal
{
    public class Boutique : DbContext
    {
         public Boutique() : base("Boutique")
            {
            }

         public DbSet<Article> Articles { get; set; }
         public DbSet<Catégorie> Catégories { get; set; }
         public DbSet<User> Users { get; set; }

         protected override void OnModelCreating(DbModelBuilder modelBuilder)
          {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
          }
        }
    }
}
}