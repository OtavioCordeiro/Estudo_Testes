using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();

            for (int i = 0; i < 10; i++)
            {
                list.AddHead(i);
            }

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nDone");
        }
    }
}
