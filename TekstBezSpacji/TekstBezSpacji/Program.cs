using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekstBezSpacji
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var x = input.Split(' ');
            var y = new List<string>();
            int a = x.Length;
            foreach (var item in x)
            {
                y.Add(item.ToLower());
            }
            Console.WriteLine(Text(y, a));
        }
        public static string Text(List <string> y, int f)
        {
            var z = new StringBuilder();
            for (int i = 0; i < f; i++)
            {
                z.Append(char.ToUpper(y[i][0]) + y[i].Substring(1));
            }
            return Convert.ToString(z);
        }
    }
}
