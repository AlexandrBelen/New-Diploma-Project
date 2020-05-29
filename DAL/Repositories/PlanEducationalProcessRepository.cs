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
    public class PlanEducationalProcessRepository : IRepositoryMain<PlanEducationalProcess, string>
    {
        private ApplicationContext context;
        public PlanEducationalProcessRepository(ApplicationContext applicationContext) => this.context = applicationContext;

        public void Create(PlanEducationalProcess item)
        {
            context.PlanEducationalProcesses.Add(item);
        }

        public void Delete(string id)
        {
            throw new Exception();
        }

        public PlanEducationalProcess Get(string id)
        {
            throw new Exception();
        }

        public IEnumerable<PlanEducationalProcess> GetAll()
        {
            List<PlanEducationalProcess> newList = context.PlanEducationalProcesses.ToList();

            for (int i = 0; i < newList.Count; ++i)
            {
                newList[i].FormDelivery = context.FormDeliveries.Where(p => p.IdDelivery == newList[i].ID_FormDelivery).SingleOrDefault();
                newList[i].UnderCycle = context.UnderCycles.Where(p => p.IdUnderCycle == newList[i].ID_UnderCycle).SingleOrDefault();
                newList[i].UnderCycle.Cycle = context.Cycles.Where(p => p.IdCycle == newList[i].UnderCycle.ID_cycle).SingleOrDefault();
            }

            return newList;
        }

        public void Update(PlanEducationalProcess item)
        {
            throw new Exception();
        }
    }
}