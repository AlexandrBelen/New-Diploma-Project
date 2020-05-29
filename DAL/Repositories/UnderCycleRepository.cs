using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repositories
{
    public class UnderCycleRepository : IRepositoryMain<UnderCycle, string>
    {
        private ApplicationContext context;
        public UnderCycleRepository(ApplicationContext applicationContext) => this.context = applicationContext;

        public void Create(UnderCycle item)
        {
            context.UnderCycles.Add(item);
        }

        public void Delete(string id)
        {
            throw new Exception();
        }

        public UnderCycle Get(string id)
        {
            var _findItem = context.UnderCycles.Where(p => p.NameUnderCycle == id);
            return _findItem.SingleOrDefault();
        }

        public IEnumerable<UnderCycle> GetAll()
        {
            return context.UnderCycles.ToList();
        }

        public void Update(UnderCycle item)
        {
            throw new Exception();
        }
    }
}
