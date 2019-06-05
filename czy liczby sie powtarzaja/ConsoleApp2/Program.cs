using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var x = input.Split('-');
            var lista = new List<int> ();
            foreach  (var i in x)
            {
                lista.Add(Convert.ToInt32(i));
            }
            lista.Sort();
            for (int i = 0; i < x.Length-1; i++)
            {
                if (lista[i] == lista[i + 1])
                {
                    Console.WriteLine("liczby sie powtarzaja");
                    return;
                }

            }
            Console.WriteLine("liczby sie nie powtarzaja");
        }
    }
}
