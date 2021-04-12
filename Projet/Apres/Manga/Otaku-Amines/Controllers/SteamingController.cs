using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Otaku_Amines.Controllers
{
    public class SteamingController : Controller
    {
        // GET: Steaming
        private MangaEntities contextEF = new MangaEntities();

        // GET: Video
        public ActionResult Streaming(string Nom, int Chiffre)
        {
            List<Episode> Episode = contextEF.Episode.ToList();

            ViewData["data"] = Episode;
            ViewData["value"] = Nom;
            ViewData["Chiffre"] = Chiffre;
            return View();
        }
    }
}