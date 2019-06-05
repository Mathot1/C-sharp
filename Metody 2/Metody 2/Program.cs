using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(10, 20);
            point.Move(new Point(40, 60));
            Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            point.Move(null); //celowe robienie bledu
            Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

            var calc = new Calculator();
            Console.WriteLine(calc.Add(1,5,2,6,8,4,2));


            //new
            int number;
            var result = int.TryParse("a", out number);
            Console.WriteLine(result);//false
        }
    }
}
