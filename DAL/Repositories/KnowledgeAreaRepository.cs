using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace DAL.Repositories
{
    public class KnowledgeAreaRepository : IRepositoryMain<KnowledgeArea, string>
    {
        private ApplicationContext context;
        public KnowledgeAreaRepository(ApplicationContext applicationContext) => this.context = applicationContext;

        public void Create(KnowledgeArea item)
        {
            context.KnowledgeAreas.Add(item);
        }

        public void Delete(string id)
        {
            KnowledgeArea program = context.KnowledgeAreas.Find(id);
            if (program != null) context.KnowledgeAreas.Remove(program);
        }

        public KnowledgeArea Get(string id)
        {
            var program = context.KnowledgeAreas.Where(p => p.areaName == id);
            return program.SingleOrDefault();
        }

        public IEnumerable<KnowledgeArea> GetAll()
        {
            return context.KnowledgeAreas.ToList();
        }

        public void Update(KnowledgeArea item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}
