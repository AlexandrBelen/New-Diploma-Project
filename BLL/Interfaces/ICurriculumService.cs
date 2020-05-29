using BLL.DTO;
using BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ICurriculumService : IDisposable
    {
        CurriculumDTO FindCurriculum(string Name);
        IEnumerable<CurriculumDTO> GetAll();

        Task<OperationDetails> Create(CurriculumDTO item);
        Task<OperationDetails> Remove(int Id);
        Task<OperationDetails> Update(int id);
        new void Dispose();
    }
}
