using BankinApp.L0.DataAccess.Domain;
using BankinApp.L1.Business.Facade;
using BankinApp.L1.Business.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BankinApp.L2.Service.Rest.Controllers
{
    public class ComptesController : ApiController
    {
        private IComptesBusiness business = new ComptesBusinessImpl();
        // GET: api/Comptes
        public IEnumerable<Compte> Get()
        {
            return business.TousLesComptes();
        }

        // GET: api/Comptes/5
        public Compte Get(string id)
        {
            return business.DetailsComptes(id);
        }

        // POST: api/Comptes
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Comptes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Comptes/5
        public void Delete(int id)
        {
        }
    }
}
