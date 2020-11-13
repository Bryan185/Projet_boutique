using Projet_hespel_bryan.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Projet_hespel_bryan.dal
{
    public class BoutiqueContext : DbContext
    {
         public BoutiqueContext() : base("BoutiqueContext")
            {
            }

         public DbSet<Article> Articles { get; set; }
        public DbSet<Categorie> Categories { get; set; }
         public DbSet<User> Users { get; set; }
        public DbSet<Constructeur> Constructeurs { get; set; }

         protected override void OnModelCreating(DbModelBuilder modelBuilder)
          {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


          }
        }
    }
