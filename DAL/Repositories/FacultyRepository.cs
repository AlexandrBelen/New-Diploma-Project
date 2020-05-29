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
    public class FacultyRepository : IRepositoryMain<Faculty, string>
    {
        private ApplicationContext context;
        public FacultyRepository(ApplicationContext applicationContext) => this.context = applicationContext;

        public void Create(Faculty item)
        {
            context.Faculties.Add(item);
        }

        public void Delete(string id)
        {
            Faculty faculty = context.Faculties.Find(id);
            if (faculty != null) context.Faculties.Remove(faculty);
        }

        public Faculty Get(string id)
        {
            var faculty = context.Faculties.Where(p => p.facultyName == id);
            return faculty.SingleOrDefault();
        }

        public IEnumerable<Faculty> GetAll()
        {
            return context.Faculties.ToList();
        }

        public void Update(Faculty item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}
