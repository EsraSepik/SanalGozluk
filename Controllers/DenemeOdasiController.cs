using Microsoft.AspNetCore.Mvc;
using SanalGozluk.Data; // Veritabanı
using SanalGozluk.Models;

namespace SanalGozluk.Controllers
{
    public class DenemeOdasiController : Controller
    {
        private readonly AppDbContext _context;

        public DenemeOdasiController(AppDbContext context)
        {
            _context = context;
        }

        // Artık burası bir ID alıyor (int id)
        public IActionResult Index(int id)
        {
            // Veritabanından o ID'li gözlüğü bul
            var secilenGozluk = _context.Gozlukler.Find(id);
            

            if (secilenGozluk == null)
            {
                return NotFound(); // Gözlük yoksa hata ver
            }

            // Gözlük bilgilerini (Özellikle 3D Model linkini) View'a gönder
            return View(secilenGozluk);
        }
    }
}