using System;
using System.Collections.Generic;
using System.Text;
using AviaProject.BLL.Intefaces;
using AviaProject.BLL.Infrastructure;
using AviaProject.DAL.Entities;
using AviaProject.DAL.Interfaces;

namespace AviaProject.BLL.Services
{
    public class TicketService : ITicketService
    {
        IUnitOfWork Database { get; set; }

        public TicketService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void BuyTicket(string passport, string tripName, string date)
        {
            Passenger passenger = Database.Passengers.Find(i=>i.Passport == passport);
            
            if (passenger == null) { throw new ValidationExeption("Current Passenger not found", ""); }
            if (Database.Tickets.Find(i => i.TripName == tripName && i.Date == date) == null) { throw new ValidationExeption("Ticket not found", ""); }
            
            Database.Tickets.Find(i => i.TripName == tripName && i.Date == date).CurrentPassenger = passenger;
            Database.Tickets.Find(i => i.TripName == tripName && i.Date == date).CurrentPlane.Passengers.Add(passenger);
        }
        public bool DelayTicket(string passport, string tripName, string date)
        {
            if (Database.Passengers.Find(i => i.Passport == passport) != new Passenger() && Database.Tickets.Find(i => i.TripName == tripName && i.Date == date) != new DAL.Entities.Ticket())
            {
                Passenger passenger = Database.Passengers.Find(i => i.Passport == passport);

                if (passenger == null) { throw new ValidationExeption("CurrentPassenger not found", ""); }
                if (Database.Tickets.Find(i => i.TripName == tripName && i.Date == date) == null) { throw new ValidationExeption("Ticket not found", ""); }

                Database.Tickets.Find(i => i.TripName == tripName && i.Date == date).CurrentPassenger = new Passenger();
                Database.Tickets.Find(i => i.TripName == tripName && i.Date == date).CurrentPlane.Passengers.Remove(passenger);
                return true;
            }
            return false;
        }

        public void CreateTicket(Ticket ticket)
        {

            if (Database.Planes.Get(ticket.CurrentPlane.Id)==null)
            {
                throw new ValidationExeption("You have inputed wrong plane", "");
            }

            Database.Tickets.Create(ticket);
        }
        public IEnumerable<Ticket> GetAllTickets()
        {
            return Database.Tickets.GetAll();
        }
        public Ticket GetTicket(int? id)
        {
            if (id == null) { throw new ValidationExeption("Ticket Id is incorrect", ""); }
            var ticket = Database.Tickets.Get(id.Value);
            if (ticket == null) { throw new ValidationExeption("Ticket not found", ""); }

            return ticket;
        }
        public Ticket FindTicket(Predicate<Ticket> predicate)
        {
            var ticket = Database.Tickets.Find(predicate);
            if (ticket == null) { throw new ValidationExeption("Ticket not found", ""); }
            return ticket;
        }
        public void UpdateTicket(Ticket ticket)
        {
            if (Database.Tickets.Find(i => i.Id == ticket.Id) == null) { throw new ValidationExeption("Ticket not found", ""); }
            Database.Tickets.Update(ticket);
        }
        public void DeleteTicket(int? id)
        {
            if (Database.Tickets.Find(i => i.Id == id) == null) { throw new ValidationExeption("Ticket not found", ""); }
            Database.Tickets.Delete(id.Value);
        }
    }
}
