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
    public class GruppaRepository : IRepositoryMain<Gruppa, string>
    {
        private ApplicationContext context;
        public GruppaRepository(ApplicationContext applicationContext) => this.context = applicationContext;
        public void Create(Gruppa item)
        {
            context.Gruppas.Add(item);
        }

        public void Delete(string id)
        {
            Gruppa gruppa = context.Gruppas.Find(id);
            if (gruppa != null) context.Gruppas.Remove(gruppa);
        }

        public Gruppa Get(string id)
        {
            var gruppa = context.Gruppas.Where(p => p.gruppaName == id);
            return gruppa.SingleOrDefault();
        }

        public IEnumerable<Gruppa> GetAll()
        {
            return context.Gruppas.ToList();
        }

        public void Update(Gruppa item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}
