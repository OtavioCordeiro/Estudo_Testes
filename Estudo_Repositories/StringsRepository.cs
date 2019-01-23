using Estudo_Component.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_Repositories
{
    public class StringsRepository : IRepository
    {
        public T GetAll<T>()
        {
            List<string> allValues = new List<string>();
            allValues.Add("Otavio");
            allValues.Add("Lopes");
            allValues.Add("Teste");

            return (T)Convert.ChangeType(allValues, typeof(T));
        }

        public T GetById<T>(int id)
        {
            var value = $"Retorna o dado de Id: {id}";
            return (T)Convert.ChangeType(value, typeof(T));
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
