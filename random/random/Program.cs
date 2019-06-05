using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var rng = new Random();
                
                Console.WriteLine("Podaj dlugosc hasla:");
                var input2 = int.Parse(Console.ReadLine());

                var abc = new char[input2];

                Console.WriteLine("Nacisnij r aby zresetowac haslo");
                while (true)
                {
                    for (int i = 0; i < input2; i++)
                    {
                        var a = rng.Next(33, 122);
                        //abc[i] = (char)rng.Next(33, 122);
                        while (a == 34 || a == 39 || a == 40 || a == 41 || a == 96 || a == 93 || a == 91 || a == 92)
                        {
                            a = rng.Next(33, 122);
                        }
                        abc[i] = (char)a;
                        // Console.WriteLine((int)rng.Next(1,10));
                        // Console.WriteLine(rng.Next(1,10));
                        // Console.WriteLine((char)rng.Next(97, 122)); //random literka
                    }
                    var haslo = new string(abc);
                    Console.WriteLine(haslo);
                    var input = Console.ReadLine();
                    if (input == "r")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Blad");
                //throw;
            }
        }
    }
}
