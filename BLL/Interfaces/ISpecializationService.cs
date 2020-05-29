using BLL.DTO;
using BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ISpecializationService : IDisposable
    {
        SpecializationDTO FindSpecialization(string UserName);
        IEnumerable<SpecializationDTO> GetAll();

        Task<OperationDetails> Create(SpecializationDTO item);
        Task<OperationDetails> Remove(int Id);
        Task<OperationDetails> Update(int id);
        new void Dispose();
    }
}
