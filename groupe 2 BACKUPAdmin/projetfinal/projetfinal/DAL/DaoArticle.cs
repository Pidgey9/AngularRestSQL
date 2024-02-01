using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using projetfinal.Models;

namespace projetfinal.DAL
{
  public class DaoArticle
  {
    public List<Articles> FindALL()
    {
      ProjetFinalECommerceEntities5 contexte = new ProjetFinalECommerceEntities5();
      return contexte.Articles.ToList<Articles>();

    }
    public Articles FindById(int idArticle)
    {
      ProjetFinalECommerceEntities5 contexte = new ProjetFinalECommerceEntities5();

      return contexte.Articles.Find(idArticle);
    }
    public List<Articles> FindByCategorie(string categorie)
    {
      ProjetFinalECommerceEntities5 contexte = new ProjetFinalECommerceEntities5();
      
        return contexte.Articles.Where(article => article.categorie == categorie).ToList();
      
    }

    public Articles Create(Articles a)
    {
      ProjetFinalECommerceEntities5 contexte = new ProjetFinalECommerceEntities5();
      contexte.Articles.Add(a);
      contexte.SaveChanges();
      return (a);

    }
    public void Delete(int idArticle)
    {
      ProjetFinalECommerceEntities5 contexte = new ProjetFinalECommerceEntities5();
      Articles a = contexte.Articles.Find(idArticle);
      contexte.Articles.Remove(a);
      contexte.SaveChanges();


    }
    public void Update(Articles a)
    {
      ProjetFinalECommerceEntities5 contexte = new ProjetFinalECommerceEntities5();
      contexte.Entry(a).State = EntityState.Modified;

      contexte.SaveChanges();
    }
  }

  }

