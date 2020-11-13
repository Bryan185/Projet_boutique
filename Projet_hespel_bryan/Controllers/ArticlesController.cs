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

namespace Projet_hespel_bryan.Controllers
{
    public class ArticlesController : Controller
    {
        private BoutiqueContext db = new BoutiqueContext();

        // GET: Articles
        public ActionResult Index()
        {
            var articles = db.Articles.Include(a => a.Catégorie).Include(a => a.Constructeur).Include(a => a.User);
            return View(articles.ToList());
        }

        // GET: Articles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        // GET: Articles/Create
        public ActionResult Create()
        {
            ViewBag.categorieID = new SelectList(db.Categories, "categorieID", "nom_categorie");
            ViewBag.constructeurID = new SelectList(db.Constructeurs, "constructeurID", "nom");
            ViewBag.userID = new SelectList(db.Users, "userID", "prenom");
            return View();
        }

        // POST: Articles/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "articleID,userID,nom_article,type,description,prix,date_transaction,date_mise,heure,categorieID,constructeurID")] Article article)
        {
            if (ModelState.IsValid)
            {
                db.Articles.Add(article);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.categorieID = new SelectList(db.Categories, "categorieID", "nom_categorie", article.categorieID);
            ViewBag.constructeurID = new SelectList(db.Constructeurs, "constructeurID", "nom", article.constructeurID);
            ViewBag.userID = new SelectList(db.Users, "userID", "prenom", article.userID);
            return View(article);
        }

        // GET: Articles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            ViewBag.categorieID = new SelectList(db.Categories, "categorieID", "nom_categorie", article.categorieID);
            ViewBag.constructeurID = new SelectList(db.Constructeurs, "constructeurID", "nom", article.constructeurID);
            ViewBag.userID = new SelectList(db.Users, "userID", "prenom", article.userID);
            return View(article);
        }

        // POST: Articles/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "articleID,userID,nom_article,type,description,prix,date_transaction,date_mise,heure,categorieID,constructeurID")] Article article)
        {
            if (ModelState.IsValid)
            {
                db.Entry(article).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.categorieID = new SelectList(db.Categories, "categorieID", "nom_categorie", article.categorieID);
            ViewBag.constructeurID = new SelectList(db.Constructeurs, "constructeurID", "nom", article.constructeurID);
            ViewBag.userID = new SelectList(db.Users, "userID", "prenom", article.userID);
            return View(article);
        }

        // GET: Articles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        // POST: Articles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Article article = db.Articles.Find(id);
            db.Articles.Remove(article);
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
    }
}
