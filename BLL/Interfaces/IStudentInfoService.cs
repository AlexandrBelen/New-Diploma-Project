using BLL.DTO;
using BLL.Infrastructure;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IStudentInfoService
    {
        Task<OperationDetails> CreateStudentInfo(StudentInfoDTO studentInfoDTO);
        StudentInfoDTO FindStudentInfo(string Name, string LastName, string bDay, string phoneNum);
        Task<OperationDetails> RemoveUser(int StudentInfoId);
        //Task<ClaimsIdentity> Authenticate(StudentInfoDTO studentInfoDto);
        Task<OperationDetails> ChangeInformation(StudentInfoDTO student);
        IEnumerable<StudentInfoDTO> GetStudentsInfo();
        
    }
}
