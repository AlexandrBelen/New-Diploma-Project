using BLL.DTO;
using BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IFormEducationService : IDisposable
    {
        FormEducationDTO FindFormEducation(string UserName);
        IEnumerable<FormEducationDTO> GetAll();

        Task<OperationDetails> Create(FormEducationDTO item);
        Task<OperationDetails> Remove(int Id);
        Task<OperationDetails> Update(int id);
        new void Dispose();
    }
}
