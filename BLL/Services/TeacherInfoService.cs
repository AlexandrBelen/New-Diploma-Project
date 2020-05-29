using BLL.DTO;
using BLL.Infrastructure;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class TeacherInfoService : ITeacherInfoService
    {
        private IUnitOfWork Database { get; set; }


        public TeacherInfoService(IUnitOfWork uow)
        {
            Database = uow;
        }

        //public Task<ClaimsIdentity> Authenticate(teacherInfoDTO teacherInfoDto)
        //{
        //    throw new NotImplementedException();
        //}

        public Task ChangeInformation()
        {
            throw new NotImplementedException();
        }

        public async Task<OperationDetails> CreateTeacherInfo(TeacherInfoDTO teacherInfoDTO)
        {
            TeacherInfo teacherInfo = new TeacherInfo()
            {
                teacherName = teacherInfoDTO.teacherName,
                teacherMiddleName = teacherInfoDTO.teacherMiddleName,
                teacherLastName = teacherInfoDTO.teacherLastName,
                bday = teacherInfoDTO.bday,
                email = teacherInfoDTO.email,
                homeAddress = teacherInfoDTO.homeAddress,
                phone = teacherInfoDTO.phone,
            };
            Database.RTeachersInfo.Create(teacherInfo);
            await Database.Save();

            return new OperationDetails(true, "teacherInfo added", "");
        }

        

        public TeacherInfoDTO FindTeacherInfo(string Name, string LastName, string bDay, string phoneNum)
        {
            TeacherInfo teacherInfo = Database.RTeachersInfo.Get(Name);
            if (teacherInfo != null)
            {
                TeacherInfoDTO teacherInfoDTO = new TeacherInfoDTO();
                teacherInfoDTO.teacherName = teacherInfo.teacherName;
                if (teacherInfo.teacherName == Name) return teacherInfoDTO;
            }
            return null;
        }

        public IEnumerable<TeacherInfoDTO> GetTeachersInfo()
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> RemoveTeacherInfo(int teacherInfoId)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> ChangeInformation(TeacherInfoDTO teacher)
        {
            throw new NotImplementedException();
        }
    }
}
