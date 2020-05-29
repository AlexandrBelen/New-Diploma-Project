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
    public class ClassroomRepository : IRepositoryMain<Classroom, string>
    {
        private ApplicationContext context;
        public ClassroomRepository(ApplicationContext applicationContext) => this.context = applicationContext;
        public void Create(Classroom item)
        {
            context.Classrooms.Add(item);
        }

        public void Delete(string id)
        {
            Classroom classroom = context.Classrooms.Find(id);
            if (classroom != null) context.Classrooms.Remove(classroom);
        }

        public Classroom Get(string room)
        {
            var classRoom = context.Classrooms.Where(p => p.classroomNum == room);
            return classRoom.SingleOrDefault();
        }

        public IEnumerable<Classroom> GetAll()
        {
            return context.Classrooms.ToList();
        }

        public void Update(Classroom item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}
