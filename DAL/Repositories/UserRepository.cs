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
    public class UserRepository : IRepositoryMain<User, string>
    {
        private ApplicationContext context;

        public UserRepository(ApplicationContext applicationContext)
        {
            this.context = applicationContext;
        }

        public void Create(User item)
        {
            context.Users.Add(item);
        }

        public void Delete(string id)
        {
            throw new Exception();
            User user = context.Users.Find(id);
            if (user != null) context.Users.Remove(user);
        }

        public User Get(string Email)
        {
            var user = context.Users.Where(p => p.Email == Email);

            return user.SingleOrDefault();
        }

        public IEnumerable<User> GetAll()
        {
            return context.Users.ToList();
        }

        public void Update(User item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}
