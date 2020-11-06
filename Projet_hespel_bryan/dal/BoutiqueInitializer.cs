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
                new User{nom="Hespel",prenom="Bryan",password="bryan",mail="bryan.hespel@condorcet.be",adresse="15, rue de la châtellenie 7700 Mouscron"}
                new User{nom="Delforge",prenom="Matteo",password="matteo4",mail="matteo@gmail.com",adresse="15, rue de la châtellenie 7700 Mouscron"}

            };

            Users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
            var Articles = new List<Article>
            {
            new Course{CourseID=1050,Title="Chemistry",Credits=3,},
            new Course{CourseID=4022,Title="Microeconomics",Credits=3,},
            new Course{CourseID=4041,Title="Macroeconomics",Credits=3,},
            new Course{CourseID=1045,Title="Calculus",Credits=4,},
            new Course{CourseID=3141,Title="Trigonometry",Credits=4,},
            new Course{CourseID=2021,Title="Composition",Credits=3,},
            new Course{CourseID=2042,Title="Literature",Credits=4,}
            };
            Articles.ForEach(s => context.Articles.Add(s));
            context.SaveChanges();
            var Catégories = new List<Catégorie>
            {
                new Catégorie{nom_categorie="Jouets"},
                new Catégorie{nom_categorie="Outils"}
            //new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            //new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            //new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            //new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            //new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            //new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
           // new Enrollment{StudentID=3,CourseID=1050},
            //new Enrollment{StudentID=4,CourseID=1050,},
           // new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
           // new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
           // new Enrollment{StudentID=6,CourseID=1045},
           // new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            Catégories.ForEach(s => context.Catégories.Add(s));
            context.SaveChanges();
            var Constructeurs = new List<Constructeur>
            {
                new Constructeur{id_article=1,nom="Sony"},
                new Constructeur{id_article=2,nom="Samsung"}
            };
            Constructeurs.ForEach(s => context.Constructeurs.Add(s));
            context.SaveChanges();
        }
    }
}