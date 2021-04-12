using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Otaku_Amines.Controllers
{
    public class HomeController : Controller
    {
        private MangaEntities contextEF = new MangaEntities();
        public string search;
        public string search2;
        public string genres;
        public ActionResult Index()
        {
            List<Animes> Animes = contextEF.Anime.ToList();
            this.search2 = "En Cours";
            ViewData["data"] = Animes;


            ViewData["value"] = search;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Search(string search)
        {

            List<Animes> Animes = contextEF.Anime.ToList();
            this.search = search;
            ViewData["data"] = Animes;


            ViewData["value"] = search;
            return View();
        }
        public ActionResult Genres(string magicButton)
        {
            List<Animes> Animes = contextEF.Anime.ToList();

            ViewData["data"] = Animes;
            switch (magicButton)
            {
                case "Action":
                    genres = "Action";
                    ViewData["value"] = genres;
                    break;
                case "Amour et Amitié":
                    genres = "Amour et Amitié";
                    ViewData["value"] = genres;
                    break;
                case "Aventure":
                    genres = "Aventure";
                    ViewData["value"] = genres;
                    break;
                case "Combats et Arts Martiaux":
                    genres = "Combats et Arts Martiaux";
                    ViewData["value"] = genres;
                    break;
                case "Comédie":
                    genres = "Comédie";
                    ViewData["value"] = genres;
                    break;
                case "Cyber & Mecha":
                    genres = "Cyber et Mecha";
                    ViewData["value"] = genres;
                    break;
                case "Drame":
                    genres = "Drame";
                    ViewData["value"] = genres;
                    break;
                case "Ecchi":
                    genres = "Ecchi";
                    ViewData["value"] = genres;
                    break;
                case "Énigme & Policier":
                    genres = "Enigme et Policier";
                    ViewData["value"] = genres;
                    break;
                case "Science-Fiction":
                    genres = "Science-Fiction";
                    ViewData["value"] = genres;
                    break;
                case "Fantastique":
                    genres = "Fantastique";
                    ViewData["value"] = genres;
                    break;
                case "Horreur":
                    genres = "Horreur";
                    ViewData["value"] = genres;
                    break;
                case "Magical girl":
                    genres = "Magical girl";
                    ViewData["value"] = genres;
                    break;
                case "Sport":
                    genres = "Sport";
                    ViewData["value"] = genres;
                    break;
                case "Tranche de vie":
                    genres = "Tranche de vie";
                    ViewData["value"] = genres;
                    break;
                case "Romance":
                    genres = "Romance";
                    ViewData["value"] = genres;
                    break;
                case "Yuri":
                    genres = "Yuri";
                    ViewData["value"] = genres;
                    break;
                case "Historique":
                    genres = "Historique";
                    ViewData["value"] = genres;
                    break;
            }
            return View();
        }
    }
}