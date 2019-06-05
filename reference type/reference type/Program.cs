using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reference_type
{
    class Program
    {
        public static void increment(int number)
        {
            number = number + 10;

        }
        public class numer
        {
           public int cyfra = 10;
        }
        public static void increment2(numer number)
        {
            number.cyfra += 10;

        }
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
           // Console.WriteLine(string.Format("a: {0}, b: {1}",a,b));

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;

            //obie tablice beda miec 0 przy pierwszym wyrazie

            // Console.WriteLine(string.Format("array1[0] {0}, array1[1] {1}, array1[2] {2}",array1[0], array1[1], array1[2]));

            var numer3 = new numer();
            increment2(numer3);

            var numer = 10;
            increment(numer);

            Console.WriteLine(numer); //i tak bedzie 10

            Console.WriteLine(numer3.cyfra); //bedzie 20

        }
    }
}
