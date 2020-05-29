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
    public class EducationalDegreeRepository : IRepositoryMain<EducationalDegree, string>
    {
        private ApplicationContext context;
        public EducationalDegreeRepository(ApplicationContext applicationContext) => this.context = applicationContext;

        public void Create(EducationalDegree item)
        {
            context.EducationalDegrees.Add(item);
        }

        public void Delete(string id)
        {
            throw new Exception();
        }

        public EducationalDegree Get(string id)
        {
            var _findItem = context.EducationalDegrees.Where(p => p.degreeName == id);
            return _findItem.SingleOrDefault();
        }

        public IEnumerable<EducationalDegree> GetAll()
        {
            return context.EducationalDegrees.ToList();
        }

        public void Update(EducationalDegree item)
        {
            throw new Exception();
        }
    }
}
