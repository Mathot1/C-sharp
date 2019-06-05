using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringi_split_i_inne
{
    class Program
    {
        static void Main(string[] args)
        {
            var imie = "mateusz blige";
            Console.WriteLine("Trim: '{0}'", imie.Trim());
            Console.WriteLine("ToUpper: '{0}'", imie.ToUpper());

            var splited = imie.Split(' ');

            Console.WriteLine(splited[0]);
            Console.WriteLine(splited[1]);

            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("blad");
            }
            var str = "92";
            Convert.ToInt32(str);

            float price = 29.95f;
            price.ToString("C");
            Console.WriteLine(price.ToString("C0"));


        }
    }
}
