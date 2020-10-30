using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet_hespel_bryan.Models
{
    public class Achat
    {
        
        public int id_article { get; set; }

        public float prix_total { get; set; }
        public int id_user { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}