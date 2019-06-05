using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 3, 1, 4, 5, 9 };

            //length
            Console.WriteLine("Length: " + numbers.Length);

            //index of
            Console.WriteLine(Array.IndexOf(numbers,3)+ " index numeru 3");

            //clear()
            Array.Clear(numbers, 0, 2);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------");
            var nex = new int[3];
            Array.Copy(numbers, nex, 3);
            foreach (var item in nex)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------");
            //sort
            Array.Sort(numbers);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            //reverse
            Console.WriteLine("------------------");
            Array.Reverse(numbers);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
