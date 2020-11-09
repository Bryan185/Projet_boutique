using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projet_hespel_bryan.Models
{
    public class Catégorie
    {
        [Key]
        public int id_categorie { get; set; }
        public string nom_categorie { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}