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
            
            var users = new List<User>
            {
            new User{prenom="Bryan",nom="Hespel",mail="bryan.hespel@condorcet.be",adresse="15, rue de la châtellenie 7700 Mouscron",password="1234"},
            new User{prenom="Matteo",nom ="Delforge",mail="matteo@gmail.com",adresse="15, rue de la châtellenie 7700 Mouscron",password="4321"},
            new User{prenom="Tia",nom ="Delforge",mail="matteo@gmail.com",adresse="15, rue de la châtellenie 7700 Mouscron",password="4321"},
            new User{prenom="JP",nom ="Delforge",mail="matteo@gmail.com",adresse="15, rue de la châtellenie 7700 Mouscron",password="4321"},
            new User{prenom="Fanny",nom ="Delforge",mail="matteo@gmail.com",adresse="15, rue de la châtellenie 7700 Mouscron",password="4321"}
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
            var categories = new List<Categorie>
            {
                new Categorie{nom_categorie="Jouets"},
                new Categorie{nom_categorie="Outils"}

            };
            categories.ForEach(ca => context.Categories.Add(ca));
            context.SaveChanges();
           
            var articles = new List<Article>
            {
            new Article{userID=2,nom_article="Samsung Galaxy S20",type="SmartPhone",prix=699,description="dernier modèle de chez Samsung"},
            new Article{userID=2,nom_article="PS5",type="Console",prix=699,description="dernier modèle de console de Sony"}
            };
            articles.ForEach(a => context.Articles.Add(a));
            context.SaveChanges();
            var constructeurs = new List<Constructeur>
            {
                new Constructeur{constructeurID='1',nom="Samsung"},
                new Constructeur{constructeurID='2',nom="Sony"}
            };
            constructeurs.ForEach(c => context.Constructeurs.Add(c));
            context.SaveChanges();



        }
            
    }         
}