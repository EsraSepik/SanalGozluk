using Microsoft.AspNetCore.Mvc;
using SanalGozluk.Data;
using SanalGozluk.Models;
using System.Linq;

namespace SanalGozluk.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string? yuzTipi)
        {
            // --- 1. SEED DATA (Veritabanı boşsa çalışır) ---
            if (!_context.Gozlukler.Any())
            {
                // 1. Ürün: Gözlük (Oval Yüzler İçin)
                var gozluk1 = new Gozluk
                {
                    Ad = "RayBan Klasik",
                    Fiyat = 1500,
                    YuzTipi = "Oval",
                    ResimUrl = "https://cdn-icons-png.flaticon.com/512/1055/1055819.png",
                    // Gözlük Linki
                    Model3DUrl = "https://cdn.jsdelivr.net/gh/hiukim/mind-ar-js@1.2.0/examples/face-tracking/assets/glasses/scene.gltf"
                };

                // 2. Ürün: Şapka (Kare Yüzler İçin)
                var gozluk2 = new Gozluk
                {
                    Ad = "Sihirli Şapka",
                    Fiyat = 850,
                    YuzTipi = "Kare",
                    ResimUrl = "https://cdn-icons-png.flaticon.com/512/10673/10673445.png", 
                    // Şapka Linki (Bu link kesin çalışıyor)
                    Model3DUrl = "https://cdn.jsdelivr.net/gh/hiukim/mind-ar-js@1.2.0/examples/face-tracking/assets/hat/scene.gltf"
                };

                _context.Gozlukler.AddRange(gozluk1, gozluk2);
                _context.SaveChanges();
            }

            // --- 2. FİLTRELEME VE LİSTELEME ---
            var sorgu = _context.Gozlukler.AsQueryable();

            if (!string.IsNullOrEmpty(yuzTipi))
            {
                sorgu = sorgu.Where(g => g.YuzTipi == yuzTipi);
            }

            var gozlukler = sorgu.ToList();
            ViewBag.SecilenTip = yuzTipi;

            return View(gozlukler);
        }
    }
}