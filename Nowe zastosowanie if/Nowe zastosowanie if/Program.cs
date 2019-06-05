using System;

namespace Nowe_zastosowanie_if
{
    class Program
    {
        static void Main(string[] args)
        {
            bool admin = true;

            float zarobki;

            if (admin)
            {
                zarobki = 1999.6f;
            }
            else
            {
                zarobki = 20.1f;
            }

            var szybszyIf = (admin) ? 1999.6f : 20.1f;
            //do zmiennej zostanie przypisana wartość ^
            Console.WriteLine(zarobki);
            Console.WriteLine(szybszyIf);


            //************************************************************************

            var sprawdz = new klasa();
            sprawdz = klasa.a;
            switch (sprawdz)
            {
                case klasa.a:
                    Console.WriteLine("Wybrales a");
                    break;

                case klasa.b:
                case klasa.c: //tak, mozna laczyc switche
                    Console.WriteLine("Wybrales b lub c");
                    break;

                case klasa.d:
                    Console.WriteLine("Wybrales d");
                    break;

                default:
                    Console.WriteLine("Wybrales niewlasciwa opcje");
                    break;
            }
        }
    }
}
