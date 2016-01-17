using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{ 
    public class ClassesController : Controller
    {
        private starwarsTOREntities2 db = new starwarsTOREntities2();

        //
        // GET: /Classes/

        public ViewResult Index()
        {
            return View(db.classes.ToList());
        }

        //
        // GET: /Classes/Details/5

        public ViewResult Details(int id)
        {
            classes classes = db.classes.Single(c => c.id == id);
            return View(classes);
        }

        //
        // GET: /Classes/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Classes/Create

        [HttpPost]
        public ActionResult Create(classes classes)
        {
            if (ModelState.IsValid)
            {
                db.classes.AddObject(classes);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(classes);
        }
        
        //
        // GET: /Classes/Edit/5
 
        public ActionResult Edit(int id)
        {
            classes classes = db.classes.Single(c => c.id == id);
            return View(classes);
        }

        //
        // POST: /Classes/Edit/5

        [HttpPost]
        public ActionResult Edit(classes classes)
        {
            if (ModelState.IsValid)
            {
                db.classes.Attach(classes);
                db.ObjectStateManager.ChangeObjectState(classes, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(classes);
        }

        //
        // GET: /Classes/Delete/5
 
        public ActionResult Delete(int id)
        {
            classes classes = db.classes.Single(c => c.id == id);
            return View(classes);
        }

        //
        // POST: /Classes/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            classes classes = db.classes.Single(c => c.id == id);
            db.classes.DeleteObject(classes);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}