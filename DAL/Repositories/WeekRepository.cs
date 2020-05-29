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
    public class WeekRepository : IRepositoryMain<Week, string>
    {
        private ApplicationContext context;
        public WeekRepository(ApplicationContext applicationContext) => this.context = applicationContext;
        public void Create(Week item)
        {
            context.Weeks.Add(item);
        }

        public void Delete(string id)
        {
            Week program = context.Weeks.Find(id);
            if (program != null) context.Weeks.Remove(program);
        }

        public Week Get(string id)
        {
            var program = context.Weeks.Where(p => p.weekNumber == id);
            return program.SingleOrDefault();
        }

        public IEnumerable<Week> GetAll()
        {
            return context.Weeks.ToList();
        }

        public void Update(Week item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}
