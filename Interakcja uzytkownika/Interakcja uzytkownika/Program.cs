using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interakcja_uzytkownika
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz liczbe miedzy 1 a 10");
            while (true)
            {
                try
                {
                    var input = Convert.ToInt32(Console.ReadLine());
                    if (input > 0 && input < 11)
                    {
                        Console.WriteLine("Wybrałeś: " + input);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Bledna liczba, spróbuj jeszcze raz");
                    }
                }
            catch (Exception)
            {
                Console.WriteLine("Wybierz LICZBE");
            }
        }
        }
    }
}
