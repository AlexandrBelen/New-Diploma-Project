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
    public class TeacherInfoRepository : IRepositoryMain<TeacherInfo, string>
    {
        private ApplicationContext context;
        public TeacherInfoRepository(ApplicationContext applicationContext) => this.context = applicationContext;
        public void Create(TeacherInfo item)
        {
            context.TeacherInfoes.Add(item);
        }

        public void Delete(string id)
        {
            TeacherInfo program = context.TeacherInfoes.Find(id);
            if (program != null) context.TeacherInfoes.Remove(program);
        }

        public TeacherInfo Get(string id)
        {
            var program = context.TeacherInfoes.Where(p => p.teacherName == id);
            return program.SingleOrDefault();
        }

        public IEnumerable<TeacherInfo> GetAll()
        {
            return context.TeacherInfoes.ToList();
        }

        public void Update(TeacherInfo item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}
