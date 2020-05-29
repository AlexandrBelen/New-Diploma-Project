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
    public class SemestrRepository : IRepositoryMain<Semestr, string>
    {
        private ApplicationContext context;
        public SemestrRepository(ApplicationContext applicationContext) => this.context = applicationContext;
        public void Create(Semestr item)
        {
            context.Semestrs.Add(item);
        }

        public void Delete(string id)
        {
            Semestr program = context.Semestrs.Find(id);
            if (program != null) context.Semestrs.Remove(program);
        }

        public Semestr Get(string id)
        {
            var program = context.Semestrs.Where(p => p.semestrNum == id);
            return program.SingleOrDefault();
        }

        public IEnumerable<Semestr> GetAll()
        {
            return context.Semestrs.ToList();
        }

        public void Update(Semestr item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}
