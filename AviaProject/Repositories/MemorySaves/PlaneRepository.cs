using System;
using System.Collections.Generic;
using System.Text;
using AviaProject.DAL.Interfaces;
using AviaProject.DAL.Entities;

namespace AviaProject.DAL.Repositories
{
    public class PlaneRepository : IRepository<Plane>
    {
        List<Plane> planes;

        public PlaneRepository(List<Plane> context)
        {
            planes = context;
        }

        public void Create(Plane item)
        {
            planes.Add(item);
        }
        public void Delete(int id)
        {
            planes.Remove(planes[planes.IndexOf(planes.Find(i => i.Id == id))]);
        }
        public Plane Find(Predicate<Plane> predicate)
        {
            return planes.Find(predicate);
        }
        public Plane Get(int id)
        {
            return planes[planes.IndexOf(planes.Find(i => i.Id == id))];
        }
        public IEnumerable<Plane> GetAll()
        {
            return planes;
        }
        public void Update(Plane item)
        {
            planes[planes.IndexOf(planes.Find(i => i.Id == item.Id))] = item;
        }

        public void Save()
        {
            
        }

        
    }
}
