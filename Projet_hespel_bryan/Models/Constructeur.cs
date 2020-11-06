using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet_hespel_bryan.Models
{
    public class Constructeur
    {
        public int id_constructeur { get; set; }
        public int id_article { get; set; }
        public string nom { get; set; }
        public virtual ICollection<Article> Articles { get; set; }


    }
}