using BankinApp.L0.DataAccess.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankinApp.L1.Business.Facade
{
    public interface IComptesBusiness
    {
        IEnumerable<Compte> TousLesComptes();
        Compte DetailsComptes(string num);
    }
}
