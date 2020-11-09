using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projet_hespel_bryan.Models;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_hespel_bryan.dal
{
    public class BoutiqueInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BoutiqueContext>
    {
        protected override void Seed(BoutiqueContext context)
        {
            var Users = new List<User>
            {
                new User{nom="Hespel",prenom="Bryan",password="bryan",mail="bryan.hespel@condorcet.be",adresse="15, rue de la châtellenie 7700 Mouscron"},
                new User{nom="Delforge",prenom="Matteo",password="matteo4",mail="matteo@gmail.com",adresse="15, rue de la châtellenie 7700 Mouscron"}

            };

            Users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
            var Articles = new List<Article>
            {
                new Article{id_acheteur=1,nom_article="Samsung Galaxy S20",type="SmartPhone",prix=699,description="dernier modèle de chez Samsung"},
                new Article{id_acheteur=1,nom_article="PS5",type="Console",prix=699,description="dernier modèle de console de Sony"}
           
            };
            Articles.ForEach(s => context.Articles.Add(s));
            context.SaveChanges();
            var Catégories = new List<Catégorie>
            {
                new Catégorie{nom_categorie="Jouets"},
                new Catégorie{nom_categorie="Outils"}
           
            };
            Catégories.ForEach(s => context.Catégories.Add(s));
            context.SaveChanges();
            var Constructeurs = new List<Constructeur>
            {
                new Constructeur{id_article=1,nom="Samsung"},
                new Constructeur{id_article=2,nom="Sony"}
            };
            Constructeurs.ForEach(s => context.Constructeurs.Add(s));
            context.SaveChanges();
        }
    }
}