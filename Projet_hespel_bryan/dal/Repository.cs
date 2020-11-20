using Projet_hespel_bryan.DTO;
using Projet_hespel_bryan.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet_hespel_bryan.dal
{
    public class Repository : IRepository
    {
        private BoutiqueContext db = new BoutiqueContext();
        public LoginDTO Authentifier(string email, string password)
        {
            var logg = (from r in db.Users where r.mail == email && r.password == password select new LoginDTO { nom = r.nom, prenom = r.prenom, id_user = r.userID }).FirstOrDefault();
            return logg;
            throw new NotImplementedException();
        }
    }
}