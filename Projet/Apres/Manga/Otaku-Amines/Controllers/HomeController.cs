using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Otaku_Amines.Models;

namespace Otaku_Amines.Controllers
{
    public class HomeController : Controller
    {
        private readonly MangaEntities contextEF = new MangaEntities();
                
        public string genres;
        public ActionResult Index()
        {
            List<Animes> Animes = contextEF.Anime.ToList();
            
           

            var vm = new ListeViewModels();
            using (var context = new MangaEntities())
            {
                var result1 = context.Anime.Where(f => f.Motif == "En Cours").OrderBy(x => x.Nom);

                foreach (var f in result1)
                {
                    var dto = new Animes
                    {
                        Nom = f.Nom,
                        Image = f.Image
                    };

                    vm.ListAnimes.Add(dto);
                }
            }
            return View(vm);
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
           
            
            var result1 = contextEF.Anime.Where(f => f.Nom.ToLower().Contains(search.ToLower())).OrderBy(x=>x.Nom);

            var vm = new ListeViewModels();
            using (var context = new MangaEntities())
            {
                foreach (var f in result1)
                {
                    var dto = new Animes
                    {
                        Nom = f.Nom,
                        Image = f.Image,
                        Genres = f.Genres,
                        Synopsis = f.Synopsis
                    };

                    vm.ListAnimes.Add(dto);
                }
            }

            
            return View(vm);
        }
        public ActionResult Genres(string magicButton)
        {
            var result1 = contextEF.Anime.Where(f => f.Genres.ToLower().Contains(magicButton.ToLower())).OrderBy(x => x.Nom);

            var vm = new ListeViewModels();
            using (var context = new MangaEntities())
            {
                foreach (var f in result1)
                {
                    var dto = new Animes
                    {
                        Nom = f.Nom,
                        Image = f.Image,
                        Genres = f.Genres,
                        Synopsis = f.Synopsis
                    };

                    vm.ListAnimes.Add(dto);
                }
            }
            return View(vm);
        }
    }
}