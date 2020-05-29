using BLL.DTO;
using BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IKnowledgeAreaService : IDisposable
    {
        KnowledgeAreaDTO FindKnowledgeArea(string Name);
        IEnumerable<KnowledgeAreaDTO> GetAll();

        Task<OperationDetails> Create(KnowledgeAreaDTO item);
        Task<OperationDetails> Remove(int Id);
        Task<OperationDetails> Update(int id);
        new void Dispose();
    }
}
