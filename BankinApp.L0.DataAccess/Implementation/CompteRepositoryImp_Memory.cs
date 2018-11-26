using BankinApp.L0.DataAccess.Domain;
using BankinApp.L0.DataAccess.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankinApp.L0.DataAccess.Implementation
{
    public class CompteRepositoryImp_Memory : IGenericRepository<Compte, string>
    {
        private static IList<Compte> data = new List<Compte> {
                new Compte { Numero = "C100 FromAPI", Proprietaire ="Mohamed", Solde = 1000M },
                new Compte { Numero = "C200 FromAPI", Proprietaire ="Amine", Solde = 2000M },
                new Compte { Numero = "C300 FromAPI", Proprietaire ="Saoudi", Solde = 3000M }};
        public void Create(Compte o)
        {
            data.Add(o);
        }

        public void Delete(string id)
        {
            data.Remove(FindById(id));
        }

        public IEnumerable<Compte> FindAll()
        {
            return data;
        }

        public Compte FindById(string id)
        {
            return data.FirstOrDefault(c => c.Numero.Equals(id));
        }

        public void Update(Compte o)
        {
            var position = data.IndexOf(FindById(o.Numero));
            if (position >= 0)
            {
                data.Insert(position, o);
            }
        }
    }
}
