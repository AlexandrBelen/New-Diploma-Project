using BLL.DTO;
using BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IEducationalDegreeService : IDisposable
    {
        EducationalDegreeDTO FindEducationalDegree(string UserName);
        IEnumerable<EducationalDegreeDTO> GetAll();

        Task<OperationDetails> Create(EducationalDegreeDTO item);
        Task<OperationDetails> Remove(int Id);
        Task<OperationDetails> Update(int id);
        new void Dispose();
    }
}
