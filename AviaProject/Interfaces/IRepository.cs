using System;
using System.Collections.Generic;
using System.Text;

namespace AviaProject.DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Create(T item);
        T Find(Predicate<T> predicate);
        T Get(int id);
        IEnumerable<T> GetAll();
        void Update(T item);
        void Delete(int id);

        void Save();
    }
}
