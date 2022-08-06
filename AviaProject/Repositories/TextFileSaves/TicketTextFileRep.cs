using System;
using System.Collections.Generic;
using System.Text;
using AviaProject.DAL.Interfaces;
using AviaProject.DAL.Entities;

namespace AviaProject.DAL.Repositories.TextFileSaves
{
    public class TicketTextFileRep : IRepository<Ticket>
    {
        string filePath;
        int numOfFields;
        List<Ticket> tickets;

        public TicketTextFileRep(string path)
        {
            filePath = path;
            numOfFields = 5;
            tickets = new List<Ticket>();

            List<string> strDb = FileWorker.ReadBlock(filePath, "Tickets begin", "Tickets end");
            for (int i = 0; i < strDb.Count; i += numOfFields)
            {
                tickets.Add(new Ticket
                {
                    Id = Convert.ToInt32(strDb[i]),
                    TripName = strDb[i + 1],
                    Date = strDb[i + 2],
                    CurrentPassenger = new Passenger { Id = Convert.ToInt32(strDb[i + 3]) },
                    CurrentPlane = new Plane { Id = Convert.ToInt32(strDb[i + 4]) }
                });
            }
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
            return tickets[tickets.IndexOf(tickets.Find(i => i.Id == id))];
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
            List<string> strDb = new List<string>();
            strDb.Add("Tickets begin");
            foreach (Ticket iter in tickets)
            {
                strDb.Add(iter.Id.ToString());
                strDb.Add(iter.TripName);
                strDb.Add(iter.Date);
                strDb.Add(iter.CurrentPassenger.Id.ToString());
                strDb.Add(iter.CurrentPlane.Id.ToString());
            }
            strDb.Add("Tickets end");
            FileWorker.AddToFile(filePath, strDb);
        }

        
    }
}
