using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AJCSPORT.EF
{
    public class DaoUser
    {
        public List<Utilisateur> FindAll()
        {
            Entities context = new Entities();
            return context.Utilisateur.ToList<Utilisateur>();
        }
        public Utilisateur FindById(int id)
        {
            Entities context = new Entities();
            return context.Utilisateur.Find(id);
        }
        public Utilisateur Create(Utilisateur u)
        {
            Entities context = new Entities();
            context.Utilisateur.Add(u);
            context.SaveChanges();
            return u;
        }
        public void Delete(int id)
        {
            Entities context = new Entities();
            Utilisateur u = context.Utilisateur.Find(id);
            context.Utilisateur.Remove(u);
            context.SaveChanges();
        }
        public Utilisateur Update(Utilisateur u)
        {
            Entities context = new Entities();
            context.Entry(u).State = EntityState.Modified;
            context.SaveChanges();
            return u;
        }
    }
}