using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace projetfinal.DAL
{
  public class DaoUtilisateur
  {
    public List<Utilisateurs> FindAll()
    {
      ProjetFinalECommerceEntities5 context = new ProjetFinalECommerceEntities5();
      return context.Utilisateurs.ToList<Utilisateurs>();
    }

    public Utilisateurs FindBylogin(string login)
    {
      ProjetFinalECommerceEntities5 context = new ProjetFinalECommerceEntities5();
      return context.Utilisateurs.Where(user => user.login.Equals(login)).FirstOrDefault();
    }

    public List<Utilisateurs> FindByMail(string EMail)
    {
      ProjetFinalECommerceEntities5 context = new ProjetFinalECommerceEntities5();
      return context.Utilisateurs.Where(user => user.e_mail.Equals(EMail)).ToList();
    }

    public Utilisateurs Create(Utilisateurs user)
    {
      ProjetFinalECommerceEntities5 context = new ProjetFinalECommerceEntities5();
      context.Utilisateurs.Add(user);
      context.SaveChanges();
      return user;
    }

    public void Delete(int id)
    { 
     ProjetFinalECommerceEntities5 context = new ProjetFinalECommerceEntities5();
    Utilisateurs user = context.Utilisateurs.Find(id);
    context.Utilisateurs.Remove(user);
      context.SaveChanges();
    }

  public void Update(Utilisateurs user)
    {
      ProjetFinalECommerceEntities5 context = new ProjetFinalECommerceEntities5();
      context.Entry(user).State = EntityState.Modified;
      context.SaveChanges();
    }
  }
}
