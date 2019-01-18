using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_Component.Repositories.Interfaces
{
    public interface IRepository
    {
        T GetAll<T>();

        T GetById<T>(int id);

        void Set<T>(T t);

        void Delete(int id);
    }
}
