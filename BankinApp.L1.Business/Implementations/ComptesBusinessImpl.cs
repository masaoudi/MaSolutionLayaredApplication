using BankinApp.L0.DataAccess.Domain;
using BankinApp.L0.DataAccess.Facade;
using BankinApp.L0.DataAccess.Implementation;
using BankinApp.L1.Business.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankinApp.L1.Business.Implementations
{
    public class ComptesBusinessImpl : IComptesBusiness
    {
        private IGenericRepository<Compte, string> repo = new CompteRepositoryImp_Memory();
        public Compte DetailsComptes(string num)
        {
            return repo.FindById(num);
        }

        public IEnumerable<Compte> TousLesComptes()
        {
            return repo.FindAll();
        }
    }
}
