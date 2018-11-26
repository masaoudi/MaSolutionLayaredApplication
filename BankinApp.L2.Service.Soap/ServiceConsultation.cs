using BankinApp.L1.Business.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace BankinApp.L2.Service.Soap
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServiceConsultation : IServiceConsultation
    {
        //private IComptesBusiness business; // inejcted buy unity

        //public ServiceConsultation(IComptesBusiness business)
        //{
        //   // this.business = business;
        //}
        public decimal ConsulterSolde(string numero)
        {
            Thread.Sleep(4000);
            return 1500.5M;
            //return business.DetailsComptes(numero).Numero;
        }
    }
}
