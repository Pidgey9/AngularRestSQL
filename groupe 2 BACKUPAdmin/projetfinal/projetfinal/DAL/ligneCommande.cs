//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projetfinal.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ligneCommande
    {
        public int id { get; set; }
        public Nullable<int> quantite { get; set; }
        public Nullable<double> prix { get; set; }
        public Nullable<int> idCommande { get; set; }
        public Nullable<int> idArticle { get; set; }
    
        public virtual Articles Articles { get; set; }
        public virtual Commande Commande { get; set; }
    }
}