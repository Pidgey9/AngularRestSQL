using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AJCSPORT.EF
{
    public class DaoArticle
    {
        public List<Articles> FindAll()
        {
            Entities context = new Entities();
            return context.Articles.ToList<Articles>();
        }
        public Articles FindById(int id)
        {
            Entities context = new Entities();
            return context.Articles.Find(id);
        }
        public Articles Create(Articles a)
        {
            Entities context = new Entities();
            context.Articles.Add(a);
            context.SaveChanges();
            return a;
        }
        public void Delete(int id)
        {
            Entities context = new Entities();
            Articles a = context.Articles.Find(id);
            context.Articles.Remove(a);
            context.SaveChanges();
        }
        public Articles Update(Articles a)
        {
            Entities context = new Entities();
            context.Entry(a).State = EntityState.Modified;
            context.SaveChanges();
            return a;
        }
    }
}