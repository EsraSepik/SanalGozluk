using Microsoft.AspNetCore.Mvc;
using SanalGozluk.Data;
using SanalGozluk.Models;
using System.Linq;

namespace SanalGozluk.Controllers
{
    public class GozlukController : Controller
    {
        private readonly AppDbContext _context;

        public GozlukController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var gozlukler = _context.Gozlukler.ToList();
            return View(gozlukler);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Gozluk gozluk)
        {
            if (ModelState.IsValid)
            {
                _context.Gozlukler.Add(gozluk);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gozluk);
        }

        // --- YENİ EKLENEN KISIM: EDIT (DÜZENLE) ---
        
        // 1. Düzenleme Sayfasını Aç (GET)
        public IActionResult Edit(int id)
        {
            var gozluk = _context.Gozlukler.Find(id);
            if (gozluk == null)
            {
                return NotFound();
            }
            return View(gozluk);
        }

        // 2. Değişiklikleri Kaydet (POST)
        [HttpPost]
        public IActionResult Edit(Gozluk gozluk)
        {
            if (ModelState.IsValid)
            {
                _context.Gozlukler.Update(gozluk);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gozluk);
        }
        // -------------------------------------------

        public IActionResult Delete(int id)
        {
            var silinecek = _context.Gozlukler.Find(id);
            if(silinecek != null)
            {
                _context.Gozlukler.Remove(silinecek);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}