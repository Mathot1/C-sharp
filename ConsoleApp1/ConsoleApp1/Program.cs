using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 1;
            int count = 100;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "ARRRRRRR";
            bool isGood = true;
            var test = 1;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isGood);
            Console.WriteLine(test);

            Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue);

        }
    }
}
