using BLL.DTO;
using BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUserService : IDisposable
    {
        UserDTO FindUser(string UserName, string Login);
        Task<ClaimsIdentity> Authenticate(UserDTO userDto);
        IEnumerable<UserDTO> GetAll();

        Task<OperationDetails> Create(UserDTO item);
        Task<OperationDetails> Remove(int Id);
        Task<OperationDetails> Update(int id);
        new void Dispose();
    }
}
