using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projetfinal.Models
{
  public class Article
  {
        private int id;
        private string nom;
        private string description;
        private string categorie;
        private double prix;
        private string image;
        public Article(int id, string nom, string description, string categorie, double prix, string image)
        {
            this.id = id;
            this.nom = nom;
            this.description = description;
            this.categorie = categorie;
            this.prix = prix;
            this.image = image;
        }
        public Article()
        {

        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }
        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }
        public string Image
        {
            get { return image; }
            set { image = value; }
        }
    }
}
