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
    public class UserController : ApiController
    {
        // GET: api/User
        public List<Utilisateur> Get()
        {
            return new DaoUser().FindAll();
        }
        // GET: api/User/5
        public Utilisateur Get(int id)
        {
            return new DaoUser().FindById(id);
        }

        // POST: api/User
        public void Post([FromBody]Utilisateur u)
        {
            new DaoUser().Create(u);
        }

        // PUT: api/User/5
        public void Put([FromBody]Utilisateur u)
        {
            new DaoUser().Update(u);
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
            new DaoUser().Delete(id);
        }
    }
}
