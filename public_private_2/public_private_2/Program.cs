using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace public_private_2
{
    public class Person
    {
        private DateTime _birthdate;

        public void SetBirthdate (DateTime birthdate)
        {
            _birthdate = birthdate;
        }
        public DateTime GetBirthdate()
        {
            return _birthdate;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
