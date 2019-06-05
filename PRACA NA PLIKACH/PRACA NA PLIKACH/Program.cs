using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRACA_NA_PLIKACH
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles(@"c:\temp", "*.*", SearchOption.AllDirectories);

            foreach (var item in files)
            {
                Console.WriteLine(item);
            }
        }
    }
}
