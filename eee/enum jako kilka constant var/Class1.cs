using System;


namespace enum_jako_kilka_constant_var
{
    public enum Metoda
    {
       Regularny = 1,
       Registered = 2,
       Express = 3
        }
    public class klasa{
       public int aa = (int)Metoda.Regularny;
       public int bb = (int)Metoda.Registered;
       public int cc = (int)Metoda.Express;
    }
}
