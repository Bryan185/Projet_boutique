using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projet_hespel_bryan.Models
{
    public class Categorie
    {
        [Key]
        public int categorieID { get; set; }
        public string nom_categorie { get; set; }

        [ForeignKey("Articles")]
        public int articleID { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}