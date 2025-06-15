using Microsoft.AspNetCore.Mvc;
using PBL_IF_31.Models;
using System.Linq;

namespace PBL_IF_31.Controllers
{
    public class DivisiController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DivisiController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.Divisis.ToList();
            return View(list);
        }

        public IActionResult Details(int id)
        {
            var divisi = _context.Divisis.Find(id);
            if (divisi == null) return NotFound();
            return View(divisi);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Divisi divisi)
        {
            if (ModelState.IsValid)
            {
                _context.Divisis.Add(divisi);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(divisi);
        }

        public IActionResult Edit(int id)
        {
            var divisi = _context.Divisis.Find(id);
            if (divisi == null) return NotFound();
            return View(divisi);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Divisi divisi)
        {
            if (id != divisi.Id) return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(divisi);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(divisi);
        }

        public IActionResult Delete(int id)
        {
            var divisi = _context.Divisis.Find(id);
            if (divisi == null) return NotFound();
            return View(divisi);
        }

        [HttpPost, ActionName("DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var divisi = _context.Divisis.Find(id);
            if (divisi != null)
            {
                _context.Divisis.Remove(divisi);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
