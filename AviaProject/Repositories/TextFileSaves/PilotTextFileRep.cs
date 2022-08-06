using System;
using System.Collections.Generic;
using System.Text;
using AviaProject.DAL.Interfaces;
using AviaProject.DAL.Entities;

namespace AviaProject.DAL.Repositories.TextFileSaves
{
    public class PilotTextFileRep : IRepository<Pilot>
    {
        string filePath;
        int numOfFields;
        List<Pilot> pilots;

        public PilotTextFileRep(string path)
        {
            filePath = path;
            numOfFields = 5;
            pilots = new List<Pilot>();

            List<string> strDb = FileWorker.ReadBlock(filePath, "Pilots begin", "Pilots end");
            for (int i = 0; i < strDb.Count; i += numOfFields)
            {
                List<Plane> temporaryPlanes = new List<Plane>();
                if (strDb[i + 4] != "")
                {
                    string[] planesId = strDb[i + 4].Split(' ');
                    foreach (string iter in planesId)
                    {
                        temporaryPlanes.Add(new Plane { Id = Convert.ToInt32(iter) });
                    }
                }
                

                pilots.Add(new Pilot
                {
                    Id = Convert.ToInt32(strDb[i]),
                    Name = strDb[i + 1],
                    Surname = strDb[i + 2],
                    Experience = Convert.ToInt32(strDb[i + 3]),
                    Planes = temporaryPlanes
                });
            }
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
            List<string> strDb = new List<string>();
            strDb.Add("Pilots begin");
            foreach (Pilot iter in pilots)
            {
                strDb.Add(iter.Id.ToString());
                strDb.Add(iter.Name);
                strDb.Add(iter.Surname);
                strDb.Add(iter.Experience.ToString());

                StringBuilder builder = new StringBuilder();
                foreach (Plane iterPlane in iter.Planes) { builder.Append(iterPlane.Id + " "); }
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
            strDb.Add("Pilots end");
            FileWorker.AddToFile(filePath, strDb);
        }

        
    }
}
