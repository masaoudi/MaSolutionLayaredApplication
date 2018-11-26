using BankinApp.L0.DataAccess.Domain;
using BankinApp.L0.DataAccess.Facade;
using BankinApp.L0.DataAccess.Implementation;
using BankinApp.L1.Business.Facade;
using BankinApp.L1.Business.Implementations;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Activation;
using System.Text;
using System.Threading.Tasks;
using Unity.Wcf;

namespace BankinApp.L2.Service.Soap.Host {
    public class WcfServiceFactory : UnityServiceHostFactory {

        protected override void ConfigureContainer(IUnityContainer container) {
            //container.LoadConfiguration();
            //UnityConfig.RegisterTypes(container);
            //container.RegisterType<IComptesBusiness, ComptesBusinessImpl>();
           // container.RegisterType<IGenericRepository<Compte,string>, CompteRepositoryImp_Memory>();

        }
    }
}
