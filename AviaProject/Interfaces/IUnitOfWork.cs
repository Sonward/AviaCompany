using System;
using System.Collections.Generic;
using System.Text;
using AviaProject.DAL.Entities;

namespace AviaProject.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Passenger> Passengers { get; }
        IRepository<Pilot> Pilots { get; }
        IRepository<Plane> Planes { get; }
        IRepository<Ticket> Tickets { get; }

        void Save();
    }
}
