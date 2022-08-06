using System;
using System.Collections.Generic;
using System.Text;
using AviaProject.DAL.Entities;

namespace AviaProject.DAL
{
    public class DBSim
    {
        public List<Plane> planes;
        public List<Passenger> passengers;
        public List<Pilot> pilots;
        public List<Ticket> tickets;

        public DBSim()
        {
            planes = new List<Plane>();
            passengers = new List<Passenger>();
            pilots = new List<Pilot>();
            tickets = new List<Ticket>();
        }

        public DBSim(List<Plane> planes, List<Passenger> passengers, List<Pilot> pilots, List<Ticket> tickets)
        {
            this.planes = planes;
            this.passengers = passengers;
            this.pilots = pilots;
            this.tickets = tickets;
        }
    }
}
