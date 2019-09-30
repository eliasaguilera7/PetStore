using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PetStore.Models;

namespace PetStore.Controllers
{
    public class PetFoodsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PetFoods
        public ActionResult Index()
        {
            return View(db.PetFoods.ToList());
        }

        // GET: PetFoods/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PetFood petFood = db.PetFoods.Find(id);
            if (petFood == null)
            {
                return HttpNotFound();
            }
            return View(petFood);
        }

        // GET: PetFoods/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PetFoods/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Price,Name,Description,NutritionalInformation,Weight,Brand,TypeOfAnimalFoodIsFor")] PetFood petFood)
        {
            if (ModelState.IsValid)
            {
                db.PetFoods.Add(petFood);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(petFood);
        }

        // GET: PetFoods/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PetFood petFood = db.PetFoods.Find(id);
            if (petFood == null)
            {
                return HttpNotFound();
            }
            return View(petFood);
        }

        // POST: PetFoods/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Price,Name,Description,NutritionalInformation,Weight,Brand,TypeOfAnimalFoodIsFor")] PetFood petFood)
        {
            if (ModelState.IsValid)
            {
                db.Entry(petFood).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(petFood);
        }

        // GET: PetFoods/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PetFood petFood = db.PetFoods.Find(id);
            if (petFood == null)
            {
                return HttpNotFound();
            }
            return View(petFood);
        }

        // POST: PetFoods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PetFood petFood = db.PetFoods.Find(id);
            db.PetFoods.Remove(petFood);
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
