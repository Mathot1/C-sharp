using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace liczenie_slow
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = @"h:/test.txt";
            string f;
            var v = File.OpenText(x);
            f = v.ReadToEnd();
            var tablica = f.Split(' ');
            Console.WriteLine(tablica.Length);
        }
    }
}
