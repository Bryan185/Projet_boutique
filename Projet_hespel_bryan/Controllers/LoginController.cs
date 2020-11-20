using Projet_hespel_bryan.dal;
using Projet_hespel_bryan.DTO;
using Projet_hespel_bryan.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projet_hespel_bryan.Controllers
{
    public class LoginController : Controller
    {
        private IRepository db;
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Connexion (String log_username, String log_password) //a utiliser dans la vue 
        {
            LoginDTO logg = db.Authentifier(log_username, log_password);
            if (logg == null)
            {
                return HttpNotFound();
            }
            Session["Nom"] = logg.nom;
            Session["Prenom"] = logg.prenom;
            Session["ID"] = logg.id_user;
            return RedirectToAction("Index", "Home");
        }
        public LoginController()
        {
            db = new Repository();
        }
            
    }
}