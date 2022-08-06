using System;
using System.Collections.Generic;
using System.Text;

namespace AviaProject.DAL.Entities
{
    public class Pilot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Experience { get; set; }
        public List<Plane> Planes { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Id + " " + Name + " " + Surname + ", " + Experience + ", ");
            foreach (Plane iter in Planes)
            {
                builder.Append(iter.Name + " ");
            }

            return builder.ToString();
        }
    }
}
