using Estudo_Component.Repositories;
using Estudo_Component.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Estudo_Api.Controllers
{
    public class ApiController : System.Web.Http.ApiController
    {
        mock mo = new mock();

        // GET api/values
        public IEnumerable<string> Get()
        {
            IRepository repository = new Repository(mo);

            return repository.GetAll<IEnumerable<string>>();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }

    public class mock : IRepository
    {
        public void Delete(int id)
        {

        }

        public T GetAll<T>()
        {
            return default(T);
        }

        public T GetById<T>(int id)
        {
            return default(T);
        }

        public void Set<T>(T t)
        {

        }
    }
}
