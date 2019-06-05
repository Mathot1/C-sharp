using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new person();
                john.FirstName = "mateusz";
            john.LastName = "Blige";
            john.Introduce();
            var test = new Test();
            var result = test.Add(1, 2);
            System.Console.WriteLine(result);
        }
    }
}
