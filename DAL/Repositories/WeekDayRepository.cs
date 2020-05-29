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
    public class WeekDayRepository : IRepositoryMain<WeekDay, string>
    {
        private ApplicationContext context;
        public WeekDayRepository(ApplicationContext applicationContext) => this.context = applicationContext;

        public void Create(WeekDay item)
        {
            context.WeekDays.Add(item);
        }

        public void Delete(string id)
        {
            WeekDay program = context.WeekDays.Find(id);
            if (program != null) context.WeekDays.Remove(program);
        }

        public WeekDay Get(string id)
        {
            var program = context.WeekDays.Where(p => p.dayName == id);
            return program.SingleOrDefault();
        }

        public IEnumerable<WeekDay> GetAll()
        {
            return context.WeekDays.ToList();
        }

        public void Update(WeekDay item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}
