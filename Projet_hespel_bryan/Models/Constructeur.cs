using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projet_hespel_bryan.Models
{
    public class Constructeur
    {
        [Key]
        public int constructeurID { get; set; }
        public string nom { get; set; }

       [ForeignKey("Articles")]
        public int articleID { get; set; }
        //public virtual Article Articles  { get; set; }
        //public virtual ICollection<Article> Articles { get; set; }

       public virtual ICollection<Article> Articles { get; set; }


    }
}