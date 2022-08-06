using System;
using System.Collections.Generic;
using System.Text;

namespace AviaProject.DAL.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public string TripName { get; set; }
        public string Date { get; set; }
        public Passenger CurrentPassenger { get; set; }
        public Plane CurrentPlane { get; set; }

        public override string ToString()
        {
            return Id + " " + TripName + ", " + CurrentPassenger.Passport + ", " + CurrentPlane.Name + ", " + Date;
        }
    }
}
