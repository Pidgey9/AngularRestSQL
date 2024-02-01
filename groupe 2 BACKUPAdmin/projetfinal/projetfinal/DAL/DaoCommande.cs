using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace projetfinal.DAL
{
  public class DaoCommande
  {
    public List<Commande> FindALL()
    {
      ProjetFinalECommerceEntities5 contexte = new ProjetFinalECommerceEntities5();
      return contexte.Commande.ToList<Commande>();

    }
    public List<Commande> FindById(int idClient)
    {
      ProjetFinalECommerceEntities5 contexte = new ProjetFinalECommerceEntities5();
      return contexte.Commande.Where(c => c.idClient == idClient).ToList();
    }


    public Commande Create(Commande c)
    {
      ProjetFinalECommerceEntities5 contexte = new ProjetFinalECommerceEntities5();
      contexte.Commande.Add(c);
      contexte.SaveChanges();
      return (c);

    }
    public void Delete(int id)
    {
      ProjetFinalECommerceEntities5 contexte = new ProjetFinalECommerceEntities5();
      Commande c = contexte.Commande.Find(id);
      contexte.Commande.Remove(c);
      contexte.SaveChanges();


    }
    public void Update(Commande c)
    {
      ProjetFinalECommerceEntities5 contexte = new ProjetFinalECommerceEntities5();
      contexte.Entry(c).State = EntityState.Modified;

      contexte.SaveChanges();
    }
    public List<Commande> SelectByClient(string id)
    {
      ProjetFinalECommerceEntities5 contexte = new ProjetFinalECommerceEntities5();
      int myId = Convert.ToInt32(id);
      return contexte.Commande.Where(c => c.idClient == myId).ToList();
    }

  }
}
