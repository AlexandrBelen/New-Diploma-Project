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
    public class ClassroomTypeRepository : IRepositoryMain<ClassroomType, string>
    {
        private ApplicationContext context;
        public ClassroomTypeRepository(ApplicationContext applicationContext) => this.context = applicationContext;
        public void Create(ClassroomType item)
        {
            context.ClassroomTypes.Add(item);
        }

        public void Delete(string id)
        {
            ClassroomType type = context.ClassroomTypes.Find(id);
            if (type != null) context.ClassroomTypes.Remove(type);
        }

        public ClassroomType Get(string type)
        {
            var roomType = context.ClassroomTypes.Where(p => p.typeName == type);
            return roomType.SingleOrDefault();
        }

        public IEnumerable<ClassroomType> GetAll()
        {
            return context.ClassroomTypes.ToList();
        }

        public void Update(ClassroomType item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}
