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
    public class TotalLoadRepository : IRepositoryMain<TotalLoad, string>
    {
        private ApplicationContext context;
        public TotalLoadRepository(ApplicationContext applicationContext) => this.context = applicationContext;
        public void Create(TotalLoad item)
        {
            context.TotalLoads.Add(item);
        }

        public void Delete(string id)
        {
            TotalLoad program = context.TotalLoads.Find(id);
            if (program != null) context.TotalLoads.Remove(program);
        }

        public TotalLoad Get(string id)
        {
            var program = context.TotalLoads.Where(p => p.studentsAmount == id);
            return program.SingleOrDefault();
        }

        public IEnumerable<TotalLoad> GetAll()
        {
            return context.TotalLoads.ToList();
        }

        public void Update(TotalLoad item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}
