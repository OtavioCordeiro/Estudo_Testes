using Estudo_Component.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_Repositories
{
    public class DataRepository : IRepository
    {
        public T GetAll<T>()
        {
            return default(T);
        }

        public T GetById<T>(int id)
        {
            throw new NotImplementedException();
        }

        public void Set<T>(T t)
        {

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
