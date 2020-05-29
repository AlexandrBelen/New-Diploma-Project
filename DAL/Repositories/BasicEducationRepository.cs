using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repositories
{
    public class BasicEducationRepository : IRepositoryMain<BasicEducation, string>
    {
        private ApplicationContext context;
        public BasicEducationRepository(ApplicationContext applicationContext) => this.context = applicationContext;
        public void Create(BasicEducation item)
        {
            context.BasicEducations.Add(item);
        }

        public void Delete(string id)
        {
            BasicEducation education = context.BasicEducations.Find(id);
            if (education != null) context.BasicEducations.Remove(education);
        }

        public BasicEducation Get(string basicEduc)
        {
            var place = context.BasicEducations.Where(p => p.place == basicEduc);
            return place.SingleOrDefault();
        }

        public IEnumerable<BasicEducation> GetAll()
        {
            return context.BasicEducations.ToList();
        }

        public void Update(BasicEducation item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}
