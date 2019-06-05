using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringi
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Mtr";

            String tea = "herbata"; //to samo

            int a;
            Int32 b;  //to samo

            var fullName = name + " " + tea;

            var fN2 = string.Format("Dwa słowa {0} {1}", name, tea);

            var names = new string[3] { "janusz", "kowal", "nowak" };

            var Formated = string.Join(",", names);
            var att = @"nowa
linia";
            Console.WriteLine(Formated);
            Console.WriteLine(att);


            

        }
    }
}
