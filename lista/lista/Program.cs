using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<int> { 1, 2, 3 };
            lista.Add(1);
            lista.AddRange(new int[3] { 1, 6, 4 });
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---" + lista.IndexOf(3));
            Console.WriteLine("+++" + lista.LastIndexOf(1));
            //count
            Console.WriteLine("Count: " + lista.Count());

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] == 1)
                {
                    lista.Remove(lista[i]);
                }
            }

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
