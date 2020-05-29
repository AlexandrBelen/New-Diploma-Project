using BLL.DTO;
using BLL.Infrastructure;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Linq;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        private IUnitOfWork Database { get; set; }

        public UserService(IUnitOfWork uow)
        {
            Database = uow;
        }



        public IEnumerable<UserDTO> GetAll()
        {
            List<User> newList = Database.RUsers.GetAll().ToList();
            List<UserDTO> newListUserDTO = new List<UserDTO>();

            for (int i = 0; i < newList.Count(); ++i)
            {
                newListUserDTO.Add(new UserDTO
                {
                    Id = newList[i].ID_user,
                    Email = newList[i].Email,
                    Password = newList[i].Password,
                    Roles = Database.RRoles.GetALL().Where(x => x.ID_role == newList[i].ID_Role).SingleOrDefault().Name
                });
            }

            return newListUserDTO;
        }

        public UserDTO FindUser(string Email, string Password)
        {
            User user = Database.RUsers.Get(Email);
            UserDTO userDTO = null;

            if (user != null)
            {
                List<Role> asd = Database.RRoles.GetALL().ToList();

                userDTO = new UserDTO();
                userDTO.Id = user.ID_user;   
                userDTO.Email = user.Email;
                userDTO.Password = user.Password;
                userDTO.Roles = Database.RRoles.GetALL().Where(x => x.ID_role == user.ID_Role).SingleOrDefault().Name;
            }

            return userDTO;
        }

        public Task<ClaimsIdentity> Authenticate(UserDTO userDto)
        {
            throw new NotImplementedException();
        }

        public async Task<OperationDetails> Create(UserDTO userDTO)
        {
            User user1 = new User() { Password = userDTO.Password, Email = userDTO.Email };
            Database.RUsers.Create(user1);
            await Database.Save();

            return new OperationDetails(true, "Registration success", "");
        }

        public async Task<OperationDetails> Update(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> Remove(int UserId)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {

        }
    }
}
