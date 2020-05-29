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
    public class PositionRepository : IRepositoryMain<Position, string>
    {
        private ApplicationContext context;
        public PositionRepository(ApplicationContext applicationContext) => this.context = applicationContext;
        public void Create(Position item)
        {
            context.Positions.Add(item);
        }

        public void Delete(string id)
        {
            Position program = context.Positions.Find(id);
            if (program != null) context.Positions.Remove(program);
        }

        public Position Get(string id)
        {
            var program = context.Positions.Where(p => p.positionName == id);
            return program.SingleOrDefault();
        }

        public IEnumerable<Position> GetAll()
        {
            return context.Positions.ToList();
        }

        public void Update(Position item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}
