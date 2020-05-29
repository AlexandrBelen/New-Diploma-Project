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
    public class StudentInfoRepository : IRepositoryMain<StudentInfo, string>
    {
        private ApplicationContext context;
        public StudentInfoRepository(ApplicationContext applicationContext) => this.context = applicationContext;
        public void Create(StudentInfo item)
        {
            context.StudentInfoes.Add(item);
        }

        public void Delete(string id)
        {
            StudentInfo program = context.StudentInfoes.Find(id);
            if (program != null) context.StudentInfoes.Remove(program);
        }

        public StudentInfo Get(string id)
        {
            var program = context.StudentInfoes.Where(p => p.studentName == id);
            return program.SingleOrDefault();
        }

        public IEnumerable<StudentInfo> GetAll()
        {
            return context.StudentInfoes.ToList();
        }

        public void Update(StudentInfo item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}
