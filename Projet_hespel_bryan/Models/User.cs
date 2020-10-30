using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet_hespel_bryan.Models
{
    public class User
    {
        public int id_user { get; set; }
        public string prenom { get; set; }
        public string nom { get; set; }

        public string mail { get; set; }

        public string adresse { get; set; }

        public string password { get; set; }
        
        
        public virtual ICollection<Article> Articles { get; set; }
    }
}