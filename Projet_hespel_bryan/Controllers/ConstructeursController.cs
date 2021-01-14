using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Projet_hespel_bryan.Models;
using Projet_hespel_bryan.dal;
using Projet_hespel_bryan.DTO;
using Projet_hespel_bryan.Interface;

namespace Projet_hespel_bryan.Controllers
{
    public class ConstructeursController : Controller
    {
        private BoutiqueContext db = new BoutiqueContext();
        private IRepository dbs;

        // GET: Constructeurs
        public ActionResult Index()
        {
            var constructeurs = db.Constructeurs.Include(a => a.Articles);
            return View(constructeurs.ToList());
        }
        public ActionResult Articlesconstru(int id)
        {
            List<ArticleDTO> liste = dbs.construct(id);
            return View(liste);
        }

        // GET: Constructeurs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Constructeur constructeur = db.Constructeurs.Find(id);
            if (constructeur == null)
            {
                return HttpNotFound();
            }
            return View(constructeur);
        }

        // GET: Constructeurs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Constructeurs/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "constructeurID,nom")] Constructeur constructeur)
        {
            if (ModelState.IsValid)
            {
                db.Constructeurs.Add(constructeur);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(constructeur);
        }

        // GET: Constructeurs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Constructeur constructeur = db.Constructeurs.Find(id);
            if (constructeur == null)
            {
                return HttpNotFound();
            }
            return View(constructeur);
        }

        // POST: Constructeurs/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "constructeurID,nom")] Constructeur constructeur)
        {
            if (ModelState.IsValid)
            {
                db.Entry(constructeur).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(constructeur);
        }

        // GET: Constructeurs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Constructeur constructeur = db.Constructeurs.Find(id);
            if (constructeur == null)
            {
                return HttpNotFound();
            }
            return View(constructeur);
        }

        // POST: Constructeurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Constructeur constructeur = db.Constructeurs.Find(id);
            db.Constructeurs.Remove(constructeur);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        public ConstructeursController()
        {
            dbs = new Repository();
        }
    }
}
