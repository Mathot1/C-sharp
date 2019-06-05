using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_jako_kilka_constant_var
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new klasa();

            var test2 = new Metoda();

            var RegularX = test.aa;
            var RegisteredX = test.bb;
            var ExpressX = test.cc;

            //wyswietlanie nazw ze zmiennych klazy "klasa"
            //zmienne klasa sa przypisywane z enum

            Console.WriteLine(RegularX);
            Console.WriteLine(RegisteredX);
            Console.WriteLine(ExpressX);

            var id_metody = 2;

            //sprawdzanie nazwy w Enum
            Console.WriteLine((Metoda)id_metody);

            //wyswietlanie enum
            Console.WriteLine(Metoda.Regularny);
        }
    }
}
