using System;
using System.Collections.Generic;
using System.Text;
using AviaProject.DAL.Interfaces;
using AviaProject.DAL.Entities;

namespace AviaProject.DAL.Repositories
{
    public class TicketRepository : IRepository<Ticket>
    {
        List<Ticket> tickets;

        public TicketRepository(List<Ticket> context)
        {
            tickets = context;
        }

        public void Create(Ticket item)
        {
            tickets.Add(item);
        }
        public void Delete(int id)
        {
            tickets.Remove(tickets[tickets.IndexOf(tickets.Find(i => i.Id == id))]);
        }
        public Ticket Find(Predicate<Ticket> predicate)
        {
            return tickets.Find(predicate);
        }
        public Ticket Get(int id)
        {
            return tickets[tickets.IndexOf(tickets.Find(i=>i.Id == id))];
        }
        public IEnumerable<Ticket> GetAll()
        {
            return tickets;
        }
        public void Update(Ticket item)
        {
            tickets[tickets.IndexOf(tickets.Find(i => i.Id == item.Id))] = item;
        }

        public void Save()
        {
            
        }

        
    }
}
