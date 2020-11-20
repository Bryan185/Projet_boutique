using Projet_hespel_bryan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet_hespel_bryan.Interface
{
    public interface IRepository
    {
        LoginDTO Authentifier(string email, string password);
        
    }
}