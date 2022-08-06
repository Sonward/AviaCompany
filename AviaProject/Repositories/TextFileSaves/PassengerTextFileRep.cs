using System;
using System.Collections.Generic;
using System.Text;
using AviaProject.DAL.Interfaces;
using AviaProject.DAL.Entities;

namespace AviaProject.DAL.Repositories.TextFileSaves
{
    public class PassengerTextFileRep : IRepository<Passenger>
    {
        string filePath;
        int numOfFields;
        List<Passenger> passengers;

        public PassengerTextFileRep(string path)
        {
            filePath = path;
            numOfFields = 5;
            passengers = new List<Passenger>();

            List<string> strDb = FileWorker.ReadBlock(filePath, "Passengers begin", "Passengers end");
            for (int i = 0; i < strDb.Count; i += numOfFields)
            {
                passengers.Add(new Passenger
                {
                    Id = Convert.ToInt32(strDb[i]),
                    Name = strDb[i+1],
                    Surname = strDb[i+2],
                    Age = Convert.ToInt32(strDb[i+3]),
                    Passport = strDb[i+4]
                });
            }
        }

        public void Create(Passenger item)
        {
            passengers.Add(item);
        }
        public void Delete(int id)
        {
            passengers.Remove(passengers[passengers.IndexOf(passengers.Find(i => i.Id == id))]);
        }
        public Passenger Find(Predicate<Passenger> predicate)
        {
            return passengers.Find(predicate);
        }
        public Passenger Get(int id)
        {
            return passengers[passengers.IndexOf(passengers.Find(i => i.Id == id))];
        }
        public IEnumerable<Passenger> GetAll()
        {
            return passengers;
        }
        public void Update(Passenger item)
        {
            passengers[passengers.IndexOf(passengers.Find(i => i.Id == item.Id))] = item;
        }

        public void Save()
        {
            List<string> strDb = new List<string>();
            strDb.Add("Passengers begin");
            foreach (Passenger iter in passengers)
            {
                strDb.Add(iter.Id.ToString());
                strDb.Add(iter.Name);
                strDb.Add(iter.Surname);
                strDb.Add(iter.Age.ToString());
                strDb.Add(iter.Passport);
            }
            strDb.Add("Passengers end");
            FileWorker.AddToFile(filePath, strDb);
        }

        
    }
}
