using System;
using System.Collections.Generic;
using System.Text;
using AviaProject.BLL.Intefaces;
using AviaProject.BLL.Infrastructure;
using AviaProject.DAL.Interfaces;
using AviaProject.DAL.Entities;

namespace AviaProject.BLL.Services
{
    public class PassengerService : IPassengerService
    {
        IUnitOfWork Database { get; set; }

        public PassengerService(IUnitOfWork uof)
        {
            Database = uof;
        }

        public List<Ticket> GetAllPassengerTickets(string passport)
        {
            List<Ticket> tickets = new List<Ticket>();
            foreach (Ticket iter in Database.Tickets.GetAll())
            {
                if (iter.CurrentPassenger.Passport == passport)
                {
                    tickets.Add(iter);
                }
            }

            return tickets;
        }

        public void CreatePassenger(Passenger passenger)
        {
            Database.Passengers.Create(passenger);
        }
        public Passenger GetPassenger(int? id)
        {
            if (id == null) { throw new ValidationExeption("Ticket Id is incorrect", ""); }
            var passenger = Database.Passengers.Get(id.Value);
            if (passenger == null) { throw new ValidationExeption("Ticket not found", ""); }

            return passenger;
        }
        public IEnumerable<Passenger> GetAllPassengers()
        {
            return Database.Passengers.GetAll();
        }
        public Passenger FindPassenger(Predicate<Passenger> predicate)
        {
            var passenger = Database.Passengers.Find(predicate);
            if (passenger == null) { throw new ValidationExeption("Ticket not found", ""); }

            return passenger;
        }
        public void UpdatePassanger(Passenger passenger)
        {
            if (Database.Passengers.Find(i=>i.Id==passenger.Id) == null) { throw new ValidationExeption("Ticket not found", ""); }
            Database.Passengers.Update(passenger);
        }
        public void DeletePassenger(int? id)
        {
            if (Database.Passengers.Find(i => i.Id ==id.Value) == null) { throw new ValidationExeption("Ticket not found", ""); }
            Database.Passengers.Delete(id.Value);
        }
    }
}
