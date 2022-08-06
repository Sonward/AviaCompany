using System;
using System.Collections.Generic;
using System.Text;
using AviaProject.DAL.Interfaces;
using AviaProject.DAL.Entities;

namespace AviaProject.DAL.Repositories
{
    public class PassengerRepository : IRepository<Passenger>
    {
        private List<Passenger> passengers;

        public PassengerRepository(List<Passenger> context)
        {
            passengers = context;
        }

        public void Create(Passenger item)
        {
            passengers.Add(item);
        }
        public void Delete(int id)
        {
            passengers.Remove(passengers[passengers.IndexOf(passengers.Find(i => i.Id == id))]);
        }
        public Passenger Find(Predicate<Passenger> predicate)
        {
            return passengers.Find(predicate);
        }
        public Passenger Get(int id)
        {
            return passengers[passengers.IndexOf(passengers.Find(i => i.Id == id))];
        }
        public IEnumerable<Passenger> GetAll()
        {
            return passengers;
        }

        public void Save()
        {
            
        }

        public void Update(Passenger item)
        {
            passengers[passengers.IndexOf(passengers.Find(i => i.Id == item.Id))] = item;
        }
    }
}
