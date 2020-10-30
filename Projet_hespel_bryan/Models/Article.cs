using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet_hespel_bryan.Models
{
    public class Article
    {
        public int id_article { get; set; }
        public int id_acheteur{ get; set; }
        public int id_vendeur { get; set; }

        public string nom_article { get; set; }
        public string type { get; set; }

        public string description { get; set; }

        public float prix { get; set; }
       
        public DateTime EnrollmentDate { get; set; }
    }
}