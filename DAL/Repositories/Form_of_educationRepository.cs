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
    public class Form_of_educationRepository : IRepositoryMain<Form_of_education, string>
    {
        private ApplicationContext context;
        public Form_of_educationRepository(ApplicationContext applicationContext) => this.context = applicationContext;

        public void Create(Form_of_education item)
        {
            context.Form_Of_Educations.Add(item);
        }

        public void Delete(string id)
        {
            throw new Exception();
        }

        public Form_of_education Get(string id)
        {
            var _findItem = context.Form_Of_Educations.Where(p => p.Name == id);
            return _findItem.SingleOrDefault();
        }

        public IEnumerable<Form_of_education> GetAll()
        {
            return context.Form_Of_Educations.ToList();
        }

        public void Update(Form_of_education item)
        {
            throw new Exception();
        }
    }
}
