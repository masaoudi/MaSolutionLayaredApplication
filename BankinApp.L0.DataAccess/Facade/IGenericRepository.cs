using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankinApp.L0.DataAccess.Facade
{
    public interface IGenericRepository<T, K> where T : class   // T = type, K = Key
    {
        //CRUD
        void Create(T o); //C du Crud
        T FindById(K id); // R du crud
        IEnumerable<T> FindAll(); // un autre R
        void Update(T o); // U du crud
        void Delete(K id); //D du Crud

    }
}
