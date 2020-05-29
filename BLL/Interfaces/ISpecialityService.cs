using BLL.DTO;
using BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ISpecialityService : IDisposable
    {
        SpecialityDTO FindSpeciality(string Name);
        IEnumerable<SpecialityDTO> GetAll();

        Task<OperationDetails> Create(SpecialityDTO item);
        Task<OperationDetails> Remove(int Id);
        Task<OperationDetails> Update(int id);
        new void Dispose();
    }
}
