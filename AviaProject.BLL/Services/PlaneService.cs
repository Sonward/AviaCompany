using System;
using System.Collections.Generic;
using System.Text;
using AviaProject.BLL.Intefaces;
using AviaProject.BLL.Infrastructure;
using AviaProject.DAL.Interfaces;
using AviaProject.DAL.Entities;

namespace AviaProject.BLL.Services
{
    public class PlaneService : IPlaneService
    {
        IUnitOfWork Database { get; set; }

        public PlaneService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void AddPilot(int? planeId, int? pilotId)
        {
            if (pilotId == null || Database.Pilots.Find(i=>i.Id == pilotId.Value) == null) { throw new ValidationExeption("Pilot not found", ""); }
            if (planeId == null || Database.Planes.Find(i => i.Id == planeId.Value) == null) { throw new ValidationExeption("Plane not found", ""); }
            if (Database.Planes.Find(i => i.Id == planeId).Pilots.Find(i=>i.Id == pilotId.Value) != null) { throw new ValidationExeption("Pilot already set in this plane", ""); }
            Database.Planes.Find(i => i.Id == planeId).Pilots.Add(Database.Pilots.Find(i => i.Id == pilotId));
            Database.Pilots.Find(i => i.Id == pilotId).Planes.Add(Database.Planes.Find(i => i.Id == planeId));
        }
        public void RemovePilot(int? planeId, int? pilotId)
        {
            if (planeId == null || Database.Planes.Find(i => i.Id == planeId.Value) == null) { throw new ValidationExeption("Plane not found", ""); }
            if (pilotId == null || Database.Planes.Find(i => i.Id == planeId.Value).Pilots.Find(i=>i.Id == pilotId) == null) { throw new ValidationExeption("Pilot not set in this plane", ""); }
            Database.Planes.Find(i => i.Id == planeId).Pilots.Remove(Database.Pilots.Find(i => i.Id == pilotId));
            Database.Pilots.Find(i => i.Id == pilotId).Planes.Remove(Database.Planes.Find(i => i.Id == planeId));
        }

        public void CreatePlane(Plane plane)
        {
            Database.Planes.Create(plane);
        }
        public IEnumerable<Plane> GetAllPlanes()
        {
            return Database.Planes.GetAll();
        }
        public Plane GetPlane(int? id)
        {
            if (id == null) { throw new ValidationExeption("CurrentPlane Id is incorrect", ""); }
            var plane = Database.Planes.Get(id.Value);
            if (plane == null) { throw new ValidationExeption("CurrentPlane not found", ""); }

            return new Plane { Id = plane.Id, Name = plane.Name, Passengers = plane.Passengers, Pilots = plane.Pilots };
        }
        public Plane FindPlane(Predicate<Plane> predicate)
        {
            var plane = Database.Planes.Find(predicate);
            if (plane == null) { throw new ValidationExeption("Plane not found", ""); }

            return plane;
        }
        public void UpdatePlane(Plane plane)
        {
            if (Database.Planes.Find(i=>i.Id==plane.Id) == null) { throw new ValidationExeption("Plane not found", ""); }

            Database.Planes.Update(plane);
        }
        public void DeletePlane(int? id)
        {
            if (Database.Planes.Find(i => i.Id == id.Value) == null) { throw new ValidationExeption("Plane not found", ""); }

            Database.Planes.Delete(id.Value);
        }
    }
}
