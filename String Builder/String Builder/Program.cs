using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            builder.Append('-', 10);
            builder.AppendLine();
            //mozna inaczej
            builder.Append("header")
                .AppendLine()
                .Append('-', 10);


            Console.WriteLine(builder);

            builder.Replace('-', '+');
            
            Console.WriteLine(builder);

        }
    }
}
