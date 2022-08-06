using System;
using System.Collections.Generic;
using System.Text;
using AviaProject.DAL.Entities;

namespace AviaProject.BLL.Intefaces
{
    public interface IPilotService
    {
        //void changePilot(string name, string surname, string planeName);
        

        void CreatePilot(Pilot pilot);
        Pilot GetPilot(int? id);
        IEnumerable<Pilot> GetAllPilots();
        Pilot FindPilot(Predicate<Pilot> predicate);
        void UpdatePilot(Pilot pilot);
        void DeletePilot(int? id);
    }
}
