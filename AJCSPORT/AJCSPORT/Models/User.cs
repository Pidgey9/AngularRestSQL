using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AJCSPORT.Models
{
    public class User
    {
        private string id;
        private string password;
        private string nom;
        private string prenom;
        private string adresse;
        private DateTime naissance;
        private string email;
        private bool isAdmin;
        public User(string id, string password, string nom, string prenom, string adresse, DateTime naissance, string email)
        {
            this.id = id;
            this.password = password;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.naissance = naissance;
            this.email = email;
        }
        public User(string id, string password, string nom, string prenom, string adresse, DateTime naissance, bool isAdmin, string email)
        {
            this.id = id;
            this.password = password;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.naissance = naissance;
            this.email = email;
            this.isAdmin = isAdmin;
        }
        public User()
        {

        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }
        public DateTime Naissance
        {
            get { return naissance; }
            set { naissance = value; }
        }
    }
}