using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {

                    var tab = new int[5];
                    for (int i = 0; i < 5; i++)
                    {
                        var input = int.Parse(Console.ReadLine());

                        tab[i] = input;

                    }
                    for (int j = 0; j < tab.Length; j++)
                    {
                        for (int i = 0; i < tab.Length; i++)
                        {
                            if (i == j)
                            {
                                continue;
                            }
                            else
                            {
                                if (tab[j] == tab[i])
                                {
                                    Console.WriteLine("Liczby sie powtarzaja");
                                    return;
                                }
                            }
                        }
                    }
                    Array.Sort(tab);
                    Console.WriteLine("------------------");
                    foreach (var item in tab)
                    {
                        Console.WriteLine(item);
                    }
                    return;

                }
                catch
                {
                    Console.WriteLine("Wybierz liczbe");
                }
            }
        }
    }
}
