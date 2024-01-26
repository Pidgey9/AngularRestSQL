using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using AJCSPORT.EF;

namespace AJCSPORT.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CommandeController : ApiController
    {
        // GET: api/Commande
        public List<Commandes> Get()
        {
            return new DaoCommande().FindAll();
        }
        // GET: api/Commande/5
        public Commandes Get(int id)
        {
            return new DaoCommande().FindById(id);
        }

        // POST: api/Commande
        public void Post([FromBody]Commandes c)
        {
            new DaoCommande().Create(c);
        }

        // PUT: api/Commande/5
        public void Put([FromBody]Commandes c)
        {
            new DaoCommande().Update(c);
        }

        // DELETE: api/Commande/5
        public void Delete(int id)
        {
            new DaoCommande().Delete(id);
        }
    }
}
