using System;
using System.Collections.Generic;
using System.Text;
using AviaProject.DAL.Entities;

namespace AviaProject.BLL.Intefaces
{
    public interface IPlaneService
    {
        void AddPilot(int? planeId, int? pilotId);
        void RemovePilot(int? planeId, int? pilotId);

        void CreatePlane(Plane plane);
        Plane GetPlane(int? id);
        IEnumerable<Plane> GetAllPlanes();
        Plane FindPlane(Predicate<Plane> predicate);
        void UpdatePlane(Plane plane);
        void DeletePlane(int? id);
    }
}
