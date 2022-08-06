using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using AviaProject.DAL;
using AviaProject.DAL.Entities;
using AviaProject.DAL.Interfaces;
using AviaProject.DAL.Repositories;
using AviaProject.DAL.Repositories.TextFileSaves;
using AviaProject.BLL.Infrastructure;
using AviaProject.BLL.Intefaces;
using AviaProject.BLL.Services;

namespace AviaProjectWF.PL
{
    static class Connection
    {
        private enum DBType { Memory = 1, TextFile = 2 };

        static public int passengersCounter = 1;
        static public int planesCounter = 1;
        static public int pilotsCounter = 1;
        static public int ticketsCounter = 1;

        static private DBType currentDB;
        static IUnitOfWork unitOW;
        static DBSim db;
        static string filePath;
        static string errorLogPath = "ErrorLog.txt";

        static public PassengerService passengerService;
        static public PilotService pilotService;
        static public PlaneService planeService;
        static public TicketService ticketService;

        static public void Initialize()
        {
            db = new DBSim();
            DBInitialize(db);
            filePath = "DataFile.txt";

            currentDB = DBType.TextFile;
            unitOW = new UnitOfWorkTextFile(filePath);

            ServiceInitialize(unitOW);
        }

        static public void ChangeDB(int id)
        {
            switch (id)
            {
                case 1:
                    unitOW.Save();
                    unitOW = new UnitOfWork(db);
                    SetIdCounts(unitOW);
                    ServiceInitialize(unitOW);
                    break;
                case 2:
                    unitOW = new UnitOfWorkTextFile(filePath);
                    SetIdCounts(unitOW);
                    ServiceInitialize(unitOW);
                    break;
                default:

                    return;
            }
        }
        static public void ChangeDB()
        {
            if (currentDB == DBType.TextFile)
            {
                currentDB = DBType.Memory;
                ChangeDB((int)currentDB);
            }
            else if (currentDB == DBType.Memory)
            {
                currentDB = DBType.TextFile;
                ChangeDB((int)currentDB);
            }
        }
        static void DBInitialize(DBSim db)
        {
            // Passengers
            db.passengers.Add(new Passenger { Id = 1, Name = "Name1", Surname = "Surmane1", Age = 5, Passport = "passport1" });
            db.passengers.Add(new Passenger { Id = 2, Name = "Name2", Surname = "Surmane2", Age = 50, Passport = "passport2" });
            db.passengers.Add(new Passenger { Id = 3, Name = "Name3", Surname = "Surmane3", Age = 15, Passport = "passport3" });
            db.passengers.Add(new Passenger { Id = 4, Name = "Name4", Surname = "Surmane4", Age = 35, Passport = "passport4" });
            db.passengers.Add(new Passenger { Id = 5, Name = "Name5", Surname = "Surmane5", Age = 51, Passport = "passport5" });

            // Pilots
            db.pilots.Add(new Pilot { Id = 1, Name = "PilotName1", Surname = "PilotSurname1", Experience = 5, Planes = new List<Plane>() });
            db.pilots.Add(new Pilot { Id = 2, Name = "PilotName2", Surname = "PilotSurname2", Experience = 1, Planes = new List<Plane>() });
            db.pilots.Add(new Pilot { Id = 3, Name = "PilotName3", Surname = "PilotSurname3", Experience = 10, Planes = new List<Plane>() });

            // Planes
            db.planes.Add(new Plane { Id = 1, Name = "Plane1", Passengers = new List<Passenger> { db.passengers[0], db.passengers[3] }, Pilots = new List<Pilot> { db.pilots[1], db.pilots[2] } });
            db.planes.Add(new Plane { Id = 2, Name = "Plane2", Passengers = new List<Passenger> { db.passengers[1], db.passengers[2], db.passengers[3] }, Pilots = new List<Pilot> { db.pilots[1], db.pilots[0] } });
            db.planes.Add(new Plane { Id = 3, Name = "Plane3", Passengers = new List<Passenger> { db.passengers[3], db.passengers[4] }, Pilots = new List<Pilot> { db.pilots[0], db.pilots[2] } });

            // Tickets
            db.tickets.Add(new Ticket { Id = 1, TripName = "Trip1", CurrentPassenger = db.passengers[1], CurrentPlane = db.planes[0], Date = "01.02.22" });
            db.tickets.Add(new Ticket { Id = 2, TripName = "Trip1", CurrentPassenger = db.passengers[0], CurrentPlane = db.planes[0], Date = "01.02.22" });
            db.tickets.Add(new Ticket { Id = 3, TripName = "Trip2", CurrentPassenger = db.passengers[4], CurrentPlane = db.planes[1], Date = "05.12.22" });

            // Pilots add planes
            db.pilots[2].Planes.Add(db.planes[0]);
            db.pilots[1].Planes.Add(db.planes[0]);
            db.pilots[1].Planes.Add(db.planes[1]);
            db.pilots[0].Planes.Add(db.planes[1]);
            db.pilots[0].Planes.Add(db.planes[2]);
            db.pilots[2].Planes.Add(db.planes[2]);

        }
        static public void ServiceInitialize(IUnitOfWork unit)
        {
            passengerService = new PassengerService(unit);
            pilotService = new PilotService(unit);
            planeService = new PlaneService(unit);
            ticketService = new TicketService(unit);

            SetIdCounts(unit);
        }
        static void SetIdCounts(IUnitOfWork unitOfWork)
        {
            int maxId = 0;
            foreach (Plane iter in unitOfWork.Planes.GetAll())
            {
                if (iter.Id > maxId) { maxId = iter.Id; }
            }
            planesCounter = maxId + 1;
            maxId = 0;
            foreach (Pilot iter in unitOfWork.Pilots.GetAll())
            {
                if (iter.Id > maxId) { maxId = iter.Id; }
            }
            pilotsCounter = maxId + 1;
            maxId = 0;
            foreach (Passenger iter in unitOfWork.Passengers.GetAll())
            {
                if (iter.Id > maxId) { maxId = iter.Id; }
            }
            passengersCounter = maxId + 1;
            maxId = 0;
            foreach (Ticket iter in unitOfWork.Tickets.GetAll())
            {
                if (iter.Id > maxId) { maxId = iter.Id; }
            }
            ticketsCounter = maxId + 1;
        }
        static public void WriteExeption(ValidationExeption exeption, string methodname)
        {
            AddErrorLog(exeption.Message, methodname);
            MessageBox.Show(exeption.Message);
        }
        static private void AddErrorLog(string log, string methodName)
        {
            string log1 = "[" + DateTime.Now.ToString() + "] " + log + " in " + methodName + ".";
            FileWorker.AddToFile(errorLogPath, new List<string> { log1 });
        }
        static public void CleanErrorLog()
        {
            FileWorker.CleanFile(errorLogPath);
        }
        static public void Save()
        {
            unitOW.Save();
        }
    }
}
