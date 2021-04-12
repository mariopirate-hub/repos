using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Otaku_Amines.Models
{
    public class ListeViewModels 
    {

        public ListeViewModels()
        {
            ListAnimes = new List<Animes>();
        }

        public List<Animes> ListAnimes { get; set; }


        public string Nom { get;  set; }

        public string Image { get; set; }
    }
}