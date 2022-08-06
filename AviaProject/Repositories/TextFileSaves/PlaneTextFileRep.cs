using System;
using System.Collections.Generic;
using System.Text;
using AviaProject.DAL.Interfaces;
using AviaProject.DAL.Entities;

namespace AviaProject.DAL.Repositories.TextFileSaves
{
    public class PlaneTextFileRep : IRepository<Plane>
    {
        string filePath;
        int numOfFields;
        List<Plane> planes;

        public PlaneTextFileRep(string path)
        {
            filePath = path;
            numOfFields = 4;
            planes = new List<Plane>();

            List<string> strDb = FileWorker.ReadBlock(filePath, "Planes begin", "Planes end");
            for (int i = 0; i < strDb.Count; i += numOfFields)
            {
                List<Passenger> temporaryPassengers = new List<Passenger>();
                if (strDb[i+2] != "")
                {
                    string[] passengersId = strDb[i + 2].Split(' ');
                    foreach (string iter in passengersId)
                    {
                        temporaryPassengers.Add(new Passenger { Id = Convert.ToInt32(iter) });
                    }
                }

                List<Pilot> temporaryPilots = new List<Pilot>();
                if (strDb[i+3] != "")
                {
                    string[] pilotsId = strDb[i + 3].Split(' ');
                    foreach (string iter in pilotsId)
                    {
                        temporaryPilots.Add(new Pilot { Id = Convert.ToInt32(iter) });
                    }
                }

                planes.Add(new Plane
                {
                    Id = Convert.ToInt32(strDb[i]),
                    Name = strDb[i + 1],
                    Passengers = temporaryPassengers,
                    Pilots = temporaryPilots
                });
            }
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
            List<string> strDb = new List<string>();
            strDb.Add("Planes begin");
            foreach (Plane iter in planes)
            {
                strDb.Add(iter.Id.ToString());
                strDb.Add(iter.Name);

                StringBuilder builder = new StringBuilder();
                foreach (Passenger iterPass in iter.Passengers) { builder.Append(iterPass.Id + " "); }
                if (builder.ToString() != "")
                {
                    string toAdd = builder.ToString().Substring(0, builder.ToString().Length - 1);
                    strDb.Add(toAdd);
                }
                else
                {
                    strDb.Add(builder.ToString());
                }

                builder = new StringBuilder();
                foreach (Pilot iterPilot in iter.Pilots) { builder.Append(iterPilot.Id + " "); }
                if (builder.ToString() != "")
                {
                    string toAdd = builder.ToString().Substring(0, builder.ToString().Length - 1);
                    strDb.Add(toAdd);
                }
                else
                {
                    strDb.Add(builder.ToString());
                }
            }
            strDb.Add("Planes end");
            FileWorker.AddToFile(filePath, strDb);
        }
    }
}
