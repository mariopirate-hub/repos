//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Episode
    {
        public int Id { get; set; }
        public int Id_Animes { get; set; }
        public string Num_Episode { get; set; }
        public string lien { get; set; }
    
        public virtual Animes Anime { get; set; }
    }
}
