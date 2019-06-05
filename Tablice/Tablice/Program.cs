using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            //moze byc var tab = new int[9];
            int[] tab = new int[9];
            tab[0] = 2;
            tab[1] = 1;
            tab[2] = 1;
            tab[3] = 5;

            var name = new string[4];
            name[0] = "abc";
            name[1] = "abc";
            name[2] = "abc";

            for (int i = 0; i<4; i++)
            {
                Console.WriteLine(tab[i]);
            }
            string tescik = string.Join(",", name);
            Console.WriteLine(tescik);

            for (int i = 0; i<5; i++)
            {//wyjdzie poza tablice
                Console.WriteLine(name[i]);
            }
            
        }
    }
}
