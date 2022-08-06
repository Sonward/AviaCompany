using System;
using System.Collections.Generic;
using System.Text;
using AviaProject.DAL.Entities;

namespace AviaProject.BLL.Intefaces
{
    public interface IPassengerService
    {
        List<Ticket> GetAllPassengerTickets(string passport);

        void CreatePassenger(Passenger passenger);
        Passenger GetPassenger(int? id);
        IEnumerable<Passenger> GetAllPassengers();
        Passenger FindPassenger(Predicate<Passenger> predicate);
        void UpdatePassanger(Passenger passenger);
        void DeletePassenger(int? id);
    }
}
