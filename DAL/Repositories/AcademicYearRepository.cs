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
    public class AcademicYearRepository : IRepositoryMain<AcademicYear, string>
    {
        private ApplicationContext context;
        public AcademicYearRepository(ApplicationContext applicationContext) => this.context = applicationContext;
        public void Create(AcademicYear item)
        {
            context.AcademicYears.Add(item);
        }

        public void Delete(string id)
        {
            AcademicYear year = context.AcademicYears.Find(id);
            if (year != null) context.AcademicYears.Remove(year);
        }

        public AcademicYear Get(string academYear)
        {
            var year = context.AcademicYears.Where(p => p.year == academYear);
            return year.SingleOrDefault();
        }

        public IEnumerable<AcademicYear> GetAll()
        {
            return context.AcademicYears.ToList();
        }

        public void Update(AcademicYear item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}
