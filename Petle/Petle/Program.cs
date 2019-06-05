using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petle
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Test 123";
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
            if (String.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("pusto");
            }
        }
    }
}
