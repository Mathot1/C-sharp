using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            while (true)
            {
                System.Console.WriteLine("Start / Stop / Wyjdz");
                var input = System.Console.ReadLine();

                switch (input)
                {
                    case "Teraz":
                        Console.WriteLine(DateTime.Now);
                        break;
                    case "Start":
                        stopwatch.Start(DateTime.Now);
                    break;
                    case "Stop":
                        stopwatch.Stop(DateTime.Now);
                        break;
                    case "Wyjdz":
                        return;
                    default:
                        System.Console.WriteLine("Wpisz odpowiednią komende");
                        break;
                }

            }
        }
    }
}
