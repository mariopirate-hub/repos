using DAL;
using Otaku_Amines.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace Otaku_Amines.Controllers
{
    public class ListeController : Controller
    {
        private readonly MangaEntities contextEF = new MangaEntities();
       
        public ActionResult Index()
        {

            List<Animes> Animes = contextEF.Anime.ToList();        
            var result = contextEF.Anime.Where(f => f.Id < 3).OrderBy(x => x.Nom);

           
            var vm = new ListeViewModels();
            using (var context = new MangaEntities())
            {
                foreach (var f in result)
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
        public ActionResult ButtonPressed(string magicButton)
        {
            List<Animes> Anime = contextEF.Anime.ToList();
                                
             var result = contextEF.Anime.Where(f => f.Nom.StartsWith(magicButton)).OrderBy(x => x.Nom);

            if(magicButton == "0")
                result = contextEF.Anime.Where(f => f.Id < 3).OrderBy(x => x.Nom);

            var vm = new ListeViewModels();
            using (var context = new MangaEntities())
            {
                foreach (var f in result)
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
