using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projet_hespel_bryan.Models
{
    public class Article
    {

        [Key]
        public int articleID { get; set; }

       
        public int userID{ get; set; }
        public virtual User User { get; set; }

       
  


        public string nom_article { get; set; }
        public string type { get; set; }

        public string description { get; set; }

        public float prix { get; set; }
       
        public DateTime date_transaction { get; set; }
        public DateTime date_mise { get; set; }
        public int heure { get; set; }

        public int categorieID{ get; set; }
        public virtual Categorie Catégorie { get; set; }

        public int constructeurID { get; set; }
        public virtual Constructeur Constructeur { get; set; }
    }
}