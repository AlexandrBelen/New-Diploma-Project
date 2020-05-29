using BLL.DTO;
using BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ICycleService : IDisposable
    {
        CycleDTO FindCycle(string UserName);
        IEnumerable<CycleDTO> GetAll();

        Task<OperationDetails> Create(CycleDTO item);
        Task<OperationDetails> Remove(int Id);
        Task<OperationDetails> Update(int id);
        new void Dispose();
    }
}
