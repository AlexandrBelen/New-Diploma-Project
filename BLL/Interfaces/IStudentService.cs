using BLL.DTO;
using BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IStudentService
    {
        Task<OperationDetails> CreateStudent(StudentDTO studentDTO);
        StudentDTO FindStudent(string info);
        Task<OperationDetails> RemoveStudent(string StudentId);
        //Task<ClaimsIdentity> Authenticate(StudentInfoDTO studentInfoDto);
        IEnumerable<StudentDTO> GetAll();
        Task ChangeInformation();
        IEnumerable<StudentDTO> GetStudents();
        
    }
}
