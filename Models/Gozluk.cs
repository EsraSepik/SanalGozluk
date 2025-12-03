using System.ComponentModel.DataAnnotations;

namespace SanalGozluk.Models
{
    public class Gozluk
    {
        public int Id { get; set; }

        [Required]
        public string Ad { get; set; }

        [Required]
        public decimal Fiyat { get; set; }

        [Required]
        public string ResimUrl { get; set; }

        [Required]
        public string Model3DUrl { get; set; }

        [Required]
        public string YuzTipi { get; set; }

        // --- YENİ EKLENEN AYARLAR ---
        // Varsayılan değerler atadık ki boş girilirse sistem bozulmasın
        public string Scale { get; set; } = "0.07 0.07 0.07"; 
        public string Rotation { get; set; } = "0 0 0";
        public string Position { get; set; } = "0 0 0";
    }
}