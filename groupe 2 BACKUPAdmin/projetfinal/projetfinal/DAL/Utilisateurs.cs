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
    
    public partial class Utilisateurs
    {
        public string login { get; set; }
        public string password { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string adresse { get; set; }
        public Nullable<System.DateTime> date_naissance { get; set; }
        public Nullable<bool> isAdmin { get; set; }
        public string e_mail { get; set; }
    }
}