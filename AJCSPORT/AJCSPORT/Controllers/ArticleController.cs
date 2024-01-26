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
    public class ArticleController : ApiController
    {
        // GET: api/Article
        public List<Articles> Get()
        {
            return new DaoArticle().FindAll();
        }
        // GET: api/Artilce/5
        public Articles Get(int id)
        {
            return new DaoArticle().FindById(id);
        }

        // POST: api/Article
        public void Post([FromBody]Articles a)
        {
            new DaoArticle().Create(a);
        }

        // PUT: api/Article/5
        public void Put([FromBody]Articles a)
        {
            new DaoArticle().Update(a);
        }

        // DELETE: api/Article/5
        public void Delete(int id)
        {
            new DaoArticle().Delete(id);
        }
    }
}
