using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasy_2
{
    public class Person
    {
        public string Name;
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.Name = "Krzysiu";
            p.Introduce("Jacek");

        }
    }
}
