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
    public class TeacherRepository : IRepositoryMain<Teacher, string>
    {
        private ApplicationContext context;
        public TeacherRepository(ApplicationContext applicationContext) => this.context = applicationContext;
        public void Create(Teacher item)
        {
            context.Teachers.Add(item);
        }

        public void Delete(string id)
        {
            Teacher program = context.Teachers.Find(id);
            if (program != null) context.Teachers.Remove(program);
        }

        public Teacher Get(string id)
        {
            var program = context.Teachers.Where(p => p.salary == id);
            return program.SingleOrDefault();
        }

        public IEnumerable<Teacher> GetAll()
        {
            return context.Teachers.ToList();
        }

        public void Update(Teacher item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}
