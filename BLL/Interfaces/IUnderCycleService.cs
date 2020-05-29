using BLL.DTO;
using BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUnderCycleService : IDisposable
    {
        UnderCycleDTO FindUnderCycle(string UserName);
        IEnumerable<UnderCycleDTO> GetAll();

        Task<OperationDetails> Create(UnderCycleDTO item);
        Task<OperationDetails> Remove(int Id);
        Task<OperationDetails> Update(int id);
        new void Dispose();
    }
}
