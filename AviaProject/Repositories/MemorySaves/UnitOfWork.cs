using System;
using System.Collections.Generic;
using System.Text;
using AviaProject.DAL.Interfaces;
using AviaProject.DAL.Entities;


namespace AviaProject.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        DBSim db;

        private PassengerRepository passengerRepository;
        private PilotRepository pilotRepository;
        private PlaneRepository planeRepository;
        private TicketRepository ticketRepository;

        public UnitOfWork(DBSim dB)
        {
            db = dB;
        }

        public IRepository<Passenger> Passengers
        {
            get
            {
                if (passengerRepository == null) { return new PassengerRepository(db.passengers); }
                return passengerRepository;
            }
        }
        public IRepository<Pilot> Pilots
        {
            get
            {
                if (pilotRepository == null) { return new PilotRepository(db.pilots); }
                return pilotRepository;
            }
        }
        public IRepository<Plane> Planes
        {
            get
            {
                if (planeRepository == null) { return new PlaneRepository(db.planes); }
                return planeRepository;
            }
        }
        public IRepository<Ticket> Tickets
        {
            get
            {
                if (ticketRepository == null) { return new TicketRepository(db.tickets); }
                return ticketRepository;
            }
        }

        public void Dispose()
        {
            
        }

        public void Save()
        {
            
        }
    }
}
