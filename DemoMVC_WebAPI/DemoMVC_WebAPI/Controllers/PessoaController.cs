using DemoMVC_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoMVC_WebAPI.Controllers
{
    public class PessoaController : ApiController
    {
        // GET api/pessoa
        public IEnumerable<Pessoa> Get()
        {
            return Pessoa.Pessoas();
        }

        // GET api/pessoa/5
        public Pessoa Get(int id)
        {
            return Pessoa.Pessoas().FirstOrDefault(x => x.Id == id);
        }

        // POST api/pessoa
        public void Post([FromBody]string value)
        {
        }

        // PUT api/pessoa/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/pessoa/5
        public void Delete(int id)
        {
        }
    }
}
