using BLL.DTO;
using BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ITeacherInfoService
    {
        Task<OperationDetails> CreateTeacherInfo(TeacherInfoDTO teacherInfoDTO);
        TeacherInfoDTO FindTeacherInfo(string Name, string LastName, string bDay, string phoneNum);
        Task<OperationDetails> RemoveTeacherInfo(int TeacherInfoId);
        //Task<ClaimsIdentity> Authenticate(StudentInfoDTO studentInfoDto);
        Task<OperationDetails> ChangeInformation(TeacherInfoDTO teacher);
        IEnumerable<TeacherInfoDTO> GetTeachersInfo();
    }
}
