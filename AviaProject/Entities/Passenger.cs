using System;
using System.Collections.Generic;
using System.Text;


namespace AviaProject.DAL.Entities
{
    public class Passenger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Passport { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return Id+" "+Name + " " + Surname + ", " + Passport + ", " + Age.ToString();
        }
    }
}
