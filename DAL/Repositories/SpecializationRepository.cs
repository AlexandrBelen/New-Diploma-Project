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
    public class SpecializationRepository : IRepositoryMain<Specialization, string>
    {
        private ApplicationContext context;
        public SpecializationRepository(ApplicationContext applicationContext) => this.context = applicationContext;

        public void Create(Specialization item)
        {
            context.Specializations.Add(item);
        }

        public void Delete(string id)
        {
            throw new Exception();
        }

        public Specialization Get(string id)
        {
            var _findItem = context.Specializations.Where(p => p.nameSpecialization == id);
            return _findItem.SingleOrDefault();
        }

        public IEnumerable<Specialization> GetAll()
        {
            return context.Specializations.ToList();
        }

        public void Update(Specialization item)
        {
            throw new Exception();
        }
    }
}
