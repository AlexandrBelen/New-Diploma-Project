using Microsoft.EntityFrameworkCore;
using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repositories
{
    public class RoleRepository : IRepositoryOnlyGet<Role>
    {
        private ApplicationContext context;

        public RoleRepository(ApplicationContext applicationContext)
        {
            this.context = applicationContext;
        }

        public IEnumerable<Role> GetALL()
        {
            return context.Roles.ToList();
        }
    }
}
