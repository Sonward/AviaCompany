using System;
using System.Collections.Generic;
using System.Text;

namespace AviaProject.DAL.Entities
{
    public class Plane
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Passenger> Passengers { get; set; }
        public List<Pilot> Pilots { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Id + " " + Name + ", ");
            foreach (Passenger iter in Passengers)
            {
                builder.Append(iter.Passport + " ");
            }
            builder.Append(", ");
            foreach (Pilot iter in Pilots)
            {
                builder.Append(iter.Name + " ");
            }

            return builder.ToString();
        }
    }
}
