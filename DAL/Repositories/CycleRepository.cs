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
    public class CycleRepository : IRepositoryMain<Cycle, string>
    {
        private ApplicationContext context;
        public CycleRepository(ApplicationContext applicationContext) => this.context = applicationContext;

        public void Create(Cycle item)
        {
            context.Cycles.Add(item);
        }

        public void Delete(string id)
        {
            throw new Exception();
        }

        public Cycle Get(string id)
        {
            var _findItem = context.Cycles.Where(p => p.NameCycle == id);
            return _findItem.SingleOrDefault();
        }

        public IEnumerable<Cycle> GetAll()
        {
            return context.Cycles.ToList();
        }

        public void Update(Cycle item)
        {
            throw new Exception();
        }
    }
}
