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
    public class CathedraRepository : IRepositoryMain<Cathedra, string>
    {
        private ApplicationContext context;
        public CathedraRepository(ApplicationContext applicationContext) => this.context = applicationContext;

        public void Create(Cathedra item)
        {
            context.Cathedra.Add(item);
        }

        public void Delete(string id)
        {
            throw new Exception();
        }

        public Cathedra Get(string id)
        {
            var _findItem = context.Cathedra.Where(p => p.cathedraName == id);
            return _findItem.SingleOrDefault();
        }

        public IEnumerable<Cathedra> GetAll()
        {
            return context.Cathedra.ToList();
        }

        public void Update(Cathedra item)
        {
            throw new Exception();
        }
    }
}
