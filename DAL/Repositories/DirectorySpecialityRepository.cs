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
    public class DirectorySpecialityRepository : IRepositoryMain<DirectorySpeciality, string>
    {
        private ApplicationContext context;
        public DirectorySpecialityRepository(ApplicationContext application) => this.context = application;


        public void Create(DirectorySpeciality item)
        {
            context.DirectorySpecialitys.Add(item);
        }

        public void Delete(string id)
        {
            DirectorySpeciality directory = context.DirectorySpecialitys.Find(id);
            if (directory != null) context.DirectorySpecialitys.Remove(directory);
        }

        public DirectorySpeciality Get(string id)
        {
            var speciality = context.DirectorySpecialitys.Where(p => p.specialityName == id);
            return speciality.SingleOrDefault();
        }

        public IEnumerable<DirectorySpeciality> GetAll()
        {
            return context.DirectorySpecialitys.ToList();
        }

        public void Update(DirectorySpeciality item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}
