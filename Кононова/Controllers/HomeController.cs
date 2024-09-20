using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Кононова.Models;

namespace Кононова.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string[] brands = { "Chanel", "Dior", "Guerlain", "Tom Ford", "Hermès", "Yves Saint Laurent", "Calvin Klein", "Dolce & Gabbana", "Versace", "Lancôme", "Givenchy", "Jo Malone", "Armani", "Paco Rabanne", "Prada", "Cartier", "Bvlgari", "Louis Vuitton", "Burberry", "Estée Lauder", "Valentino", "Hugo Boss", "Kenzo", "Salvatore Ferragamo", "Jean Paul Gaultier", "Michael Kors", "Marc Jacobs", "Balenciaga", "Mugler", "Carolina Herrera", "Narciso Rodriguez", "Tommy Hilfiger", "Creed", "Byredo", "Maison Francis Kurkdjian", "Clive Christian", "Amouage", "Le Labo", "Diptyque", "Atelier Cologne", "Zadig & Voltaire", "Azzaro", "Montblanc", "Comme des Garçons", "Gucci", "Penhaligon's", "Maison Margiela", "Bond No. 9", "Serge Lutens", "Victoria's Secret", "Fendi", "L'Artisan Parfumeur", "Acqua di Parma", "Frederic Malle", "Tiziana Terenzi", "Annick Goutal", "Initio Parfums Privés", "Roja Parfums", "Xerjoff", "Zegna", "Mancera", "Montale", "Parfums de Marly", "House of Sillage", "Juliette Has A Gun", "Miu Miu", "Celine", "Ralph Lauren", "Elie Saab", "Viktor & Rolf" };
            ViewData["Brands"] = brands;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Some()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
