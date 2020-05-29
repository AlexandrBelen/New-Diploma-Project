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
    public class ParaNumberRepository : IRepositoryMain<ParaNumber, string>
    {
        private ApplicationContext context;
        public ParaNumberRepository(ApplicationContext applicationContext) => this.context = applicationContext;
        public void Create(ParaNumber item)
        {
            context.ParaNumbers.Add(item);
        }

        public void Delete(string id)
        {
            ParaNumber program = context.ParaNumbers.Find(id);
            if (program != null) context.ParaNumbers.Remove(program);
        }

        public ParaNumber Get(string id)
        {
            var program = context.ParaNumbers.Where(p => p.paraTime == id);
            return program.SingleOrDefault();
        }

        public IEnumerable<ParaNumber> GetAll()
        {
            return context.ParaNumbers.ToList();
        }

        public void Update(ParaNumber item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}
