using System;
using System.Collections.Generic;
using System.Text;
using AviaProject.DAL.Entities;

namespace AviaProject.BLL.Intefaces
{
    public interface ITicketService
    {
        void BuyTicket(string passport, string tripName, string date);
        bool DelayTicket(string passport, string tripName, string date);

        void CreateTicket(Ticket ticket);
        Ticket GetTicket(int? id);
        IEnumerable<Ticket> GetAllTickets();
        Ticket FindTicket(Predicate<Ticket> predicate);
        void UpdateTicket(Ticket ticket);
        void DeleteTicket(int? id);
    }
}
