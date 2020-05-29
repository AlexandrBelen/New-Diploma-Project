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
    public class FormDeliveryRepository : IRepositoryMain<FormDelivery, string>
    {
        private ApplicationContext context;
        public FormDeliveryRepository(ApplicationContext applicationContext) => this.context = applicationContext;

        public void Create(FormDelivery item)
        {
            context.FormDeliveries.Add(item);
        }

        public void Delete(string id)
        {
            throw new Exception();
        }

        public FormDelivery Get(string id)
        {
            var _findItem = context.FormDeliveries.Where(p => p.NameDelivery == id);
            return _findItem.SingleOrDefault();
        }

        public IEnumerable<FormDelivery> GetAll()
        {
            return context.FormDeliveries.ToList();
        }

        public void Update(FormDelivery item)
        {
            throw new Exception();
        }
    }
}
