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
    public class SheduleRepository : IRepositoryMain<Shedule, int>
    {
        private ApplicationContext context;
        public SheduleRepository(ApplicationContext applicationContext) => this.context = applicationContext;
        public void Create(Shedule item)
        {
            context.Shedules.Add(item);
        }

        public void Delete(int id)
        {
            Shedule program = context.Shedules.Find(id);
            if (program != null) context.Shedules.Remove(program);
        }

        public Shedule Get(int id)
        {
            var program = context.Shedules.Where(p => p.IdShedule == id);
            return program.SingleOrDefault();
        }

        public IEnumerable<Shedule> GetAll()
        {
            return context.Shedules.ToList();
        }

        public void Update(Shedule item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}
