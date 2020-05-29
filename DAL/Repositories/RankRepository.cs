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
    public class RankRepository : IRepositoryMain<Rank, string>
    {
        private ApplicationContext context;
        public RankRepository(ApplicationContext applicationContext) => this.context = applicationContext;
        public void Create(Rank item)
        {
            context.Ranks.Add(item);
        }

        public void Delete(string id)
        {
            Rank program = context.Ranks.Find(id);
            if (program != null) context.Ranks.Remove(program);
        }

        public Rank Get(string id)
        {
            var program = context.Ranks.Where(p => p.rankName == id);
            return program.SingleOrDefault();
        }

        public IEnumerable<Rank> GetAll()
        {
            return context.Ranks.ToList();
        }

        public void Update(Rank item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}
