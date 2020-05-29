using BLL.DTO;
using BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IPlanEducationalProcessService : IDisposable
    {
        PlanEducationalProcessDTO FindPlanEducationalProcess(string name);
        IEnumerable<PlanEducationalProcessDTO> GetAllOneCurriculun(int id);

        Task<OperationDetails> Create(PlanEducationalProcessDTO item);
        Task<OperationDetails> Remove(int Id);
        Task<OperationDetails> Update(int id);
        new void Dispose();
    }
}
