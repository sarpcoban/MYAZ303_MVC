using Microsoft.AspNetCore.Mvc;
using MYAZ303_MVC.Data;
using MYAZ303_MVC.Models;

namespace MYAZ303_MVC.Controllers
{
    public class SarkiController : Controller
    {

        private readonly ApplicationDbContext _db;

        public SarkiController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Sarki> objSarkiList = _db.Sarkilar;
            return View(objSarkiList);
        }

        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Sarki obj)
        {
            if (ModelState.IsValid)
            {
                _db.Sarkilar.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var sarkiFromDb = _db.Sarkilar.Find(id);


            if (sarkiFromDb == null)
            {
                return NotFound();
            }

            return View(sarkiFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Sarki obj)
        {

            if (ModelState.IsValid)
            {
                
                _db.Sarkilar.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var sarkiFromDb = _db.Sarkilar.Find(id);
            if (sarkiFromDb == null)
            {
                return NotFound();
            }
            return View(sarkiFromDb);
        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.Sarkilar.Find(id);
            if (obj == null) {
                return NotFound();
            }
            _db.Sarkilar.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
