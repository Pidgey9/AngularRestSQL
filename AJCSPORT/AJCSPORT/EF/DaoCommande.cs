using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AJCSPORT.EF
{
    public class DaoCommande
    {
        public List<Commandes> FindAll()
        {
            Entities context = new Entities();
            return context.Commandes.ToList<Commandes>();
        }
        public Commandes FindById(int id)
        {
            Entities context = new Entities();
            return context.Commandes.Find(id);
        }
        public Commandes Create(Commandes c)
        {
            Entities context = new Entities();
            context.Commandes.Add(c);
            context.SaveChanges();
            return c;
        }
        public void Delete(int id)
        {
            Entities context = new Entities();
            Commandes c = context.Commandes.Find(id);
            context.Commandes.Remove(c);
            context.SaveChanges();
        }
        public Commandes Update(Commandes c)
        {
            Entities context = new Entities();
            context.Entry(c).State = EntityState.Modified;
            context.SaveChanges();
            return c;
        }
    }
}