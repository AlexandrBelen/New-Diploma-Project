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
    public class StudentRepository : IRepositoryMain<Student, string>
    {
        private ApplicationContext context;
        public StudentRepository(ApplicationContext applicationContext) => this.context = applicationContext;
        public void Create(Student item)
        {
            context.Students.Add(item);
        }

        public void Delete(string id)
        {
            int q = Convert.ToInt32(id);
            Student program = context.Students.Find(q);
            if (program != null) context.Students.Remove(program);
        }

        public Student Get(string id)
        {
            int q = Convert.ToInt32(id);
            var program = context.Students.Where(p => p.id_studentInfo == q);
            return program.SingleOrDefault();
        }

        public IEnumerable<Student> GetAll()
        {
            return context.Students.ToList();
        }

        public void Update(Student item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}
