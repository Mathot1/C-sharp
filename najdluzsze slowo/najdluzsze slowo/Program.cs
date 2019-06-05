using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace najdluzsze_slowo
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = @"h:/test.txt";
            var v = File.OpenText(x);
            var f = v.ReadToEnd();
            var tablica = f.Split(' ');
            var slowa = new List<int>();
            for (int i = 0; i < tablica.Length; i++)
            {
                slowa.Add(tablica[i].Length);
            }
            slowa.Sort();
            Console.WriteLine(slowa[tablica.Length - 1]);
        }
    }
}
