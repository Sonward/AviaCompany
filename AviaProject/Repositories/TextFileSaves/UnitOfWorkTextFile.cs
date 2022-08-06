using System;
using System.Collections.Generic;
using System.Text;
using AviaProject.DAL.Interfaces;
using AviaProject.DAL.Entities;

namespace AviaProject.DAL.Repositories.TextFileSaves
{
    public class UnitOfWorkTextFile : IUnitOfWork
    {
        string pathToDataFile;

        private PassengerTextFileRep passengerRepository;
        private PilotTextFileRep pilotRepository;
        private PlaneTextFileRep planeRepository;
        private TicketTextFileRep ticketRepository;

        public UnitOfWorkTextFile(string path)
        {
            pathToDataFile = path;

            passengerRepository = new PassengerTextFileRep(pathToDataFile);
            pilotRepository = new PilotTextFileRep(pathToDataFile);
            planeRepository = new PlaneTextFileRep(pathToDataFile);
            ticketRepository = new TicketTextFileRep(pathToDataFile);

            InitializePilots();
            InitializePlanes();
            InitializeTickets();
        }

        public IRepository<Passenger> Passengers
        {
            get
            {
                if (passengerRepository == null) { return new PassengerTextFileRep(pathToDataFile); }
                return passengerRepository;
            }
        }
        public IRepository<Pilot> Pilots
        {
            get
            {
                if (pilotRepository == null) { return new PilotTextFileRep(pathToDataFile); }
                return pilotRepository;
            }
        }
        public IRepository<Plane> Planes
        {
            get
            {
                if (planeRepository == null) { return new PlaneTextFileRep(pathToDataFile); }
                return planeRepository;
            }
        }
        public IRepository<Ticket> Tickets
        {
            get
            {
                if (ticketRepository == null) { return new TicketTextFileRep(pathToDataFile); }
                return ticketRepository;
            }
        }

        public void Dispose()
        {
            
        }

        public void Save()
        {
            FileWorker.CleanFile(pathToDataFile);
            Passengers.Save();
            Pilots.Save();
            Planes.Save();
            Tickets.Save();
        }

        // Заповнює колонки які мають посилання на інші сутності
        private void InitializePilots()
        {
            List<Pilot> initializedPilots = new List<Pilot>();
            if (Pilots.GetAll() == null) { return; }
            foreach (Pilot iterPilot in Pilots.GetAll())
            {
                List<Plane> newPlanes = new List<Plane>();
                foreach (Plane planeIter in iterPilot.Planes)
                {
                    foreach (Plane iterPlane in Planes.GetAll())
                    {
                        if (planeIter.Id == iterPlane.Id) { newPlanes.Add(iterPlane); }
                    }
                }
                initializedPilots.Add(new Pilot
                {
                    Id = iterPilot.Id,
                    Name = iterPilot.Name,
                    Surname = iterPilot.Surname,
                    Experience = iterPilot.Experience,
                    Planes = newPlanes
                });
            }
            
            foreach (Pilot iter in initializedPilots)
            {
                Pilots.Update(iter);
            }
        }
        private void InitializePlanes()
        {
            List<Plane> initializedPlanes = new List<Plane>();
            foreach (Plane iterPlane in Planes.GetAll())
            {
                List<Pilot> newPilots = new List<Pilot>();
                List<Passenger> newPassengers = new List<Passenger>();
                foreach (Pilot pilotIter in iterPlane.Pilots)
                {
                    foreach (Pilot iterPilot in Pilots.GetAll())
                    {
                        if (pilotIter.Id == iterPilot.Id) { newPilots.Add(iterPilot); }
                    }
                }
                foreach(Passenger passengerIter in iterPlane.Passengers)
                {
                    foreach (Passenger iterPassenger in Passengers.GetAll())
                    {
                        if (passengerIter.Id == iterPassenger.Id) { newPassengers.Add(iterPassenger); }
                    }
                }
                initializedPlanes.Add(new Plane 
                {
                    Id = iterPlane.Id,
                    Name = iterPlane.Name,
                    Passengers = newPassengers,
                    Pilots = newPilots
                });
            }

            foreach (Plane iter in initializedPlanes)
            {
                Planes.Update(iter);
            }
        }
        private void InitializeTickets()
        {
            List<Ticket> initializedTickets = new List<Ticket>();
            foreach (Ticket ticketIter in Tickets.GetAll())
            {
                Passenger newPassenger = new Passenger();
                Plane newPlane = new Plane();
                foreach (Passenger passengerIter in Passengers.GetAll())
                {
                    if (ticketIter.CurrentPassenger.Id == passengerIter.Id) { newPassenger = passengerIter; }
                }
                foreach (Plane planeIter in Planes.GetAll())
                {
                    if (ticketIter.CurrentPlane.Id == planeIter.Id) { newPlane = planeIter; }
                }
                initializedTickets.Add(new Ticket
                {
                    Id = ticketIter.Id,
                    TripName = ticketIter.TripName,
                    Date = ticketIter.Date,
                    CurrentPassenger = newPassenger,
                    CurrentPlane = newPlane
                });
            }

            foreach (Ticket iter in initializedTickets)
            {
                Tickets.Update(iter);
            }
        }
    }
}
