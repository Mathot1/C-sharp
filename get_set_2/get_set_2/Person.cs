using System;

namespace get_set_2
{
    public class Person
    {


        public DateTime Birthdate { get; private set; }
        public string Name { get; set; }
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        

        public int Age
        {
            get
            {
               var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
    }
}
