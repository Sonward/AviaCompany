using System;
using System.Collections.Generic;
using System.Text;
using AviaProject.BLL.Intefaces;
using AviaProject.BLL.Infrastructure;
using AviaProject.DAL.Entities;
using AviaProject.DAL.Interfaces;

namespace AviaProject.BLL.Services
{
    public class PilotService : IPilotService
    {
        IUnitOfWork Database { get; set; }

        public PilotService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void CreatePilot(Pilot pilot)
        {
            Database.Pilots.Create(pilot);
        }
        public IEnumerable<Pilot> GetAllPilots()
        {
            if (Database.Pilots.GetAll() == null) { throw new ValidationExeption("Pilot's data is empty", ""); }
            return Database.Pilots.GetAll();
        }
        public Pilot GetPilot(int? id)
        {
            if (id == null) { throw new ValidationExeption("Pilot Id is incorrect", ""); }
            var pilot = Database.Pilots.Get(id.Value);
            if (pilot == null) { throw new ValidationExeption("Pilot not found", ""); }

            return pilot;
        }
        public Pilot FindPilot(Predicate<Pilot> predicate)
        {
            var pilot = Database.Pilots.Find(predicate);
            if (pilot == null) { throw new ValidationExeption("Pilot not found", ""); }
            return pilot;
        }
        public void UpdatePilot(Pilot pilot)
        {
            if (Database.Pilots.Find(i=>i.Id == pilot.Id) == null) { throw new ValidationExeption("Pilot not found", ""); }
            Database.Pilots.Update(pilot);
        }
        public void DeletePilot(int? id)
        {
            if (Database.Pilots.Find(i => i.Id == id.Value) == null) { throw new ValidationExeption("Pilot not found", ""); }
            Database.Pilots.Delete(id.Value);
        }
    }
}
