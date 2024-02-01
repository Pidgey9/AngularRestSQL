using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projetfinal.Models
{
  public class Commande
  {
        private int id;
        private int idClient;
        private DateTime date;
        private double prixTotal;
        private string infos;
        public Commande(int idClient, DateTime date, double prixTotal, string infos)
        {
            this.idClient = idClient;
            this.date = date;
            this.prixTotal = prixTotal;
            this.infos = infos;
        }
        public Commande(int id, int idClient, DateTime date, double prixTotal, string infos)
        {
            this.id = id;
            this.idClient = idClient;
            this.date = date;
            this.prixTotal = prixTotal;
            this.infos = infos;
        }
        public Commande()
        {

        }
        public int Id
        {
            get { return id; }
        }
        public int IdClient
        {
            get { return idClient; }
        }
        public DateTime Date
        {
            get { return date; }
        }
        public double PrixTotal
        {
            get { return prixTotal; }
        }
        public string Infos
        {
            get { return infos; }
        }

    }
}
