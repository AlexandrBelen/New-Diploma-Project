using BLL.DTO;
using BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IFacultyService : IDisposable
    {
        FacultyDTO FindFaculty(string facultyName);
        IEnumerable<FacultyDTO> GetAll();

        Task<OperationDetails> Create(FacultyDTO item);
        Task<OperationDetails> Remove(int Id);
        Task<OperationDetails> Update(int id);
        new void Dispose();
    }
}