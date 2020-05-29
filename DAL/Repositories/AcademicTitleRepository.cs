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
    public class AcademicTitleRepository : IRepositoryMain<AcademicTitle, string>
    {
        private ApplicationContext context;

        public AcademicTitleRepository(ApplicationContext applicationContext) => this.context = applicationContext;


        public void Create(AcademicTitle item)
        {
            context.AcademicTitles.Add(item);
        }

        public void Delete(string id)
        {
            AcademicTitle academicTitle = context.AcademicTitles.Find(id);
            if (academicTitle != null) context.AcademicTitles.Remove(academicTitle);
        }

        public AcademicTitle Get(string acaTitleName)
        {
            var title = context.AcademicTitles.Where(P => P.academicTitleName == acaTitleName);
            return title.SingleOrDefault();
        }

        public IEnumerable<AcademicTitle> GetAll()
        {
            return context.AcademicTitles.ToList();
        }

        public void Update(AcademicTitle item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}
