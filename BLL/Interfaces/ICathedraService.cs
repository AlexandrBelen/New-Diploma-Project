using BLL.DTO;
using BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ICathedraService : IDisposable
    {
        CathedraDTO FindCathedra(string UserName);
        IEnumerable<CathedraDTO> GetAll();

        Task<OperationDetails> Create(CathedraDTO item);
        Task<OperationDetails> Remove(int Id);
        Task<OperationDetails> Update(int id);
        new void Dispose();
    }
}
