using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dzielenieprzez3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ile liczb program ma sprawdzic czy sa podzielne przez 3:");
            int x = 0;
            while (true)
            {
                try
                {
                    var input = int.Parse(Console.ReadLine());
                    for (int i = 0; i< input; i++)
                    {
                        if (i%3 == 0)
                        {
                            x++;
                        }
                    }
                    Console.WriteLine("W przedziale od 0 do " + input + " wystepuje " + x + " liczb podzielnych przez 3");
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("Podaj liczbę całkowitą");
                    continue;
                }

            }
        }
    }
}
