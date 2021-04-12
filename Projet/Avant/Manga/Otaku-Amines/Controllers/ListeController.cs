using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Otaku_Amines.Controllers
{
    public class ListeController : Controller
    {
        private MangaEntities contextEF = new MangaEntities();
        public string Lettre;
        public ActionResult Index()
        {

            List<Animes> Animes = contextEF.Anime.ToList();

            ViewData["data"] = Animes;

            Lettre = "9";
            ViewData["value"] = Lettre;
            return View();
        }
        public ActionResult ButtonPressed(string magicButton)
        {
            List<Animes> Anime = contextEF.Anime.ToList();

            ViewData["data"] = Anime;
            ViewData["value"] = magicButton;

            
            return View();
        }
    }
}
