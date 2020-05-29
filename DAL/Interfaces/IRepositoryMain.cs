using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IRepositoryMain<TClass, TId> where TClass : class
    {
        TClass Get(TId id);
        void Create(TClass item);
        void Update(TClass item);
        void Delete(TId id);
        IEnumerable<TClass> GetAll();
    }   
}
