using System;

namespace kurs_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string str = "true";
                bool bb = bool.Parse(str);
            }
            catch (Exception)
            {
                Console.WriteLine("Number cannot be converted to a byte");
            }
            int b = 1000;
            byte i = (byte)b;
            Console.WriteLine(i);
            
        }
    }
}
