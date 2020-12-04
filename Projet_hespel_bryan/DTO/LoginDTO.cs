using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet_hespel_bryan.DTO
{
    public class LoginDTO
    {

        public int id_user { get; set; }
        public String nom { get; set; }
        public String prenom { get; set; }
        public String adresse { get; set; }
        public String password { get; set; }
        public String mail { get; set; }
    }
}