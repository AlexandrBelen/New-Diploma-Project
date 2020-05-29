using BLL.DTO;
using BLL.Infrastructure;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StudentInfoService : IStudentInfoService
    {
        private IUnitOfWork Database { get; set; }


        public StudentInfoService(IUnitOfWork uow)
        {
            Database = uow;
        }

        //public Task<ClaimsIdentity> Authenticate(StudentInfoDTO studentInfoDto)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<OperationDetails> ChangeInformation(StudentInfoDTO studentInfoDTO)
        {
            string id = Convert.ToString(studentInfoDTO.studentInfoID);
            StudentInfo studentInfo = Database.RStudentsInfo.Get(id);
            if (studentInfo == null) throw new ValidationException("Student is not found", id);
            StudentInfo student = new StudentInfo();
            studentInfo.stundtInfoID = student.stundtInfoID;
            studentInfo.studentName = student.studentName;
            studentInfo.studentMiddleName = student.studentMiddleName;
            studentInfo.studentLastName = student.studentLastName;
            studentInfo.bday = student.bday;
            studentInfo.studentSex = student.studentSex;
            studentInfo.email = student.email;
            studentInfo.homeAddress = student.homeAddress;
            studentInfo.phone = student.phone;
            studentInfo.StudentFirstParentName = student.StudentFirstParentName;
            studentInfo.StudentFirstParentPhone = student.StudentFirstParentPhone;
            studentInfo.StudentSecondParentName = student.StudentSecondParentName;
            studentInfo.StudentSecondParentPhone = student.StudentSecondParentPhone;
            Database.RStudentsInfo.Update(student);
            await Database.Save();
            return new OperationDetails(true, "User successfully changed", "UserProfile");

        }

        public async Task<OperationDetails> CreateStudentInfo(StudentInfoDTO studentInfoDTO)
        {
            StudentInfo studentInfo = new StudentInfo()
            {
                studentName = studentInfoDTO.studentName,
                studentMiddleName = studentInfoDTO.studentMiddleName,
                studentLastName = studentInfoDTO.studentLastName,
                bday = studentInfoDTO.bday,
                email = studentInfoDTO.email,
                studentSex = studentInfoDTO.studentSex,
                homeAddress = studentInfoDTO.homeAddress,
                phone = studentInfoDTO.phone,
                StudentFirstParentName = studentInfoDTO.StudentFirstParentName,
                StudentFirstParentPhone = studentInfoDTO.StudentFirstParentPhone,
                StudentSecondParentName = studentInfoDTO.StudentSecondParentName,
                StudentSecondParentPhone = studentInfoDTO.StudentSecondParentPhone
            };
            Database.RStudentsInfo.Create(studentInfo);
            await Database.Save();

            return new OperationDetails(true, "StudentInfo added", "");
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public StudentInfoDTO FindStudentInfo(string Name, string LastName, string bDay, string phoneNum)
        {
            StudentInfo studentInfo = Database.RStudentsInfo.Get(Name);
            if (studentInfo != null)
            {
                StudentInfoDTO studentInfoDTO = new StudentInfoDTO();
                studentInfoDTO.studentName = studentInfo.studentName;
                if (studentInfo.studentName == Name) return studentInfoDTO;  
            }
            return null;
        }

        public IEnumerable<StudentInfoDTO> GetStudentsInfo()
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> RemoveUser(int StudentInfoId)
        {
            string st = Convert.ToString(StudentInfoId);
            StudentInfo student = Database.RStudentsInfo.Get(st);
            if (student == null) throw new ValidationException("Student is not found", "");
            throw new NotImplementedException();
        }
    }
}
