using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daty_i_godziny
{
    class Program
    {
        static void Main(string[] args)
        {
            var czas = new DateTime(2015, 1, 1);
            var teraz = new DateTime();
            var timeSpan = new TimeSpan(1, 2, 3);//godzina / minuta / sekunda

            Console.WriteLine("hour: " + teraz.Hour);
            Console.WriteLine(czas);
            Console.WriteLine(czas.ToString("yyyy-MM-dd"));

            Console.WriteLine(timeSpan.Seconds);
            Console.WriteLine(timeSpan.Minutes);
            Console.WriteLine(timeSpan.Hours);
        }
    }
}