using BLL.DTO;
using BLL.Infrastructure;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StudentService : IStudentService
    {
        private IUnitOfWork Database { get; set; }


        public StudentService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public Task ChangeInformation()
        {
            throw new NotImplementedException();
        }

        public async Task<OperationDetails> CreateStudent(StudentDTO studentDTO)
        {
            Student student = new Student()
            {
                stundentID = studentDTO.IdStudent,
                id_gruppa = studentDTO.gruppa,
                id_speciality = studentDTO.speciality,
                year = studentDTO.year,
                id_cathedra = studentDTO.cathedra,
                educationProgram = studentDTO.educationProgram,
                id_faculty = studentDTO.faculty
            };
            Database.RStudents.Create(student);
            await Database.Save();

            return new OperationDetails(true, "Student added sucessfuly", "");
        }

        


        public StudentDTO FindStudent(string info)
        {
            Student student = Database.RStudents.Get(info);
            if (student != null)
            {
                StudentDTO studentDTO = new StudentDTO();
                studentDTO.year = student.year;
                if (student.year == info) return studentDTO;
            }

            return null;

        }

        public IEnumerable<StudentDTO> GetStudents()
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> RemoveStudent(string StudentId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StudentDTO> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
