using Projet_hespel_bryan.dal;
using Projet_hespel_bryan.DTO;
using Projet_hespel_bryan.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projet_hespel_bryan.Models;
using System.Web.Mvc;

namespace Projet_hespel_bryan.Controllers
{
    public class LoginController : Controller
    {
        private BoutiqueContext dbs = new BoutiqueContext();
        private IRepository db;
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Deco()
        {
                
                Session.Abandon();
            return RedirectToAction("Index", "Home");
            
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
            Session["Email"] = logg.mail;
            Session["Adresse"] = logg.adresse;
            Session["Password"] = logg.password;
            return RedirectToAction("Index", "Home");
        }
     
        public ActionResult Inscription()
        {
            return View();
        }

        // POST: Users/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Inscription([Bind(Include = "userID,prenom,nom,mail,adresse,password")] User user)
        {
            if (ModelState.IsValid)
            {
                dbs.Users.Add(user);
                dbs.SaveChanges();
                return RedirectToAction("Index", "Login");
            }

            return View(user);
        }
        
        public LoginController()
        {
            db = new Repository();
        }
            
    }
}