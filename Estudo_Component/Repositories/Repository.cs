using Estudo_Component.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_Component.Repositories
{
    public class Repository : IRepository
    {
        IRepository inner;

        public Repository(IRepository repository)
        {
            inner = repository;
        }

        public T GetAll<T>()
        {
            return inner.GetAll<T>();
        }

        public T GetById<T>(int id)
        {
            return inner.GetById<T>(id);
        }

        public void Set<T>(T t)
        {
            if (t != null)
            {
                inner.Set(t);
            }
        }

        public void Delete(int id)
        {
            if (id != 0)
            {
                inner.Delete(id);
            }
        }
    }
}
