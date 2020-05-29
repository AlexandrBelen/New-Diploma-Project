using BLL.DTO;
using BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ITeacherService
    {
        Task<OperationDetails> CreateTeacher(TeacherDTO teacherDTO);
        TeacherDTO FindTeacher(string info);
        Task<OperationDetails> RemoveTeacher(string teacherId);
        //Task<ClaimsIdentity> Authenticate(StudentInfoDTO studentInfoDto);
        Task ChangeInformation();
        IEnumerable<TeacherDTO> GetAll();
        IEnumerable<TeacherDTO> GetTeachers();
    }
}
