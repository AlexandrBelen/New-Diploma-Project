using BLL.DTO;
using BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IFormDeliveryService : IDisposable
    {
        FormDeliveryDTO FindFormDelivery(string UserName);
        IEnumerable<FormDeliveryDTO> GetAll();

        Task<OperationDetails> Create(FormDeliveryDTO item);
        Task<OperationDetails> Remove(int Id);
        Task<OperationDetails> Update(int id);
        new void Dispose();
    }
}
