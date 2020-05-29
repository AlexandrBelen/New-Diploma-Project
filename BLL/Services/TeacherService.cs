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
    public class TeacherService : ITeacherService
    {
        private IUnitOfWork Database { get; set; }

        public TeacherService(IUnitOfWork uow) => Database = uow;
        public Task ChangeInformation()
        {
            throw new NotImplementedException();
        }

        public async Task<OperationDetails> CreateTeacher(TeacherDTO teacherDTO)
        {
            Teacher teacher = new Teacher()
            {
                id_position = teacherDTO.position,
                salary = teacherDTO.salary,
                id_rank = teacherDTO.rank,
                id_academicTitle = teacherDTO.academicTitle,
                staff = teacherDTO.staff,
                employmentYear = teacherDTO.employmentYear,
                releaseYear = teacherDTO.releaseYear,
                teacherInfoId = teacherDTO.teacherInfoId
            };
            Database.RTeachers.Create(teacher);
            await Database.Save();
            return new OperationDetails(true, "Teacher success", "");
        }


        public TeacherDTO FindTeacher(string info)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TeacherDTO> GetTeachers()
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> RemoveTeacher(string teacherId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TeacherDTO> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
