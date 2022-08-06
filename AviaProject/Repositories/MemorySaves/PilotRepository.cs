using System;
using System.Collections.Generic;
using System.Text;
using AviaProject.DAL.Interfaces;
using AviaProject.DAL.Entities;

namespace AviaProject.DAL.Repositories
{
    public class PilotRepository : IRepository<Pilot>
    {
        private List<Pilot> pilots;

        public PilotRepository(List<Pilot> context)
        {
            pilots = context;
        }

        public void Create(Pilot item)
        {
            pilots.Add(item);
        }
        public Pilot Find(Predicate<Pilot> predicate)
        {
            return pilots.Find(predicate);
        }
        public Pilot Get(int id)
        {
            return pilots[pilots.IndexOf(pilots.Find(i => i.Id == id))];
        }
        public IEnumerable<Pilot> GetAll()
        {
            return pilots;
        }
        public void Update(Pilot item)
        {
            pilots[pilots.IndexOf(pilots.Find(i => i.Id == item.Id))] = item;
        }
        public void Delete(int id)
        {
            pilots.Remove(pilots[pilots.IndexOf(pilots.Find(i => i.Id == id))]);
        }

        public void Save()
        {
            
        }
    }
}
