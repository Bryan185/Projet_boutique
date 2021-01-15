using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projet_hespel_bryan.DTO
{
    public class VenteDTO
    {
        public int articleID{ get; set; }
        public string nom_article { get; set; }

        public string type { get; set; }
      
       
        public Boolean etat { get; set; }
        public int userID { get; set; }
        public float prix { get; set; }
        [DataType(DataType.Date)]
        public DateTime? date_transaction { get; set; }
        [DataType(DataType.Date)]
        public DateTime? date_mise { get; set; }


    }
}