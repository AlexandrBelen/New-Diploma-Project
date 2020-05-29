using BLL.DTO;
using BLL.Infrastructure;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Linq;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BLL.Services
{
    public class FacultyService : IFacultyService
    {
        private IUnitOfWork Database { get; set; }

        public FacultyService(IUnitOfWork uow)
        {
            Database = uow;
        }



        public IEnumerable<FacultyDTO> GetAll()
        {
            List<Faculty> newList = Database.RFaculties.GetAll().ToList();
            List<FacultyDTO> newListFacultyDTO = new List<FacultyDTO>();

            for (int i = 0; i < newList.Count(); ++i)
            {
                newListFacultyDTO.Add(new FacultyDTO
                {
                    facultyName = newList[i].facultyName,
                    IdFaculty = newList[i].IdFaculty,
                    facultyAddress = newList[i].facultyAddress
                });
            }

            return newListFacultyDTO;
        }

        public FacultyDTO FindFaculty(string name)
        {
            Faculty faculty = Database.RFaculties.Get(name);
            FacultyDTO facultyDTO = null;

            if (faculty != null)
            {
                facultyDTO = new FacultyDTO();

                facultyDTO.facultyName = faculty.facultyName;
                facultyDTO.IdFaculty = faculty.IdFaculty;
                facultyDTO.facultyAddress = faculty.facultyAddress;
            }

            return facultyDTO;
        }

        public async Task<OperationDetails> Create(FacultyDTO facultyDTO)
        {
            Faculty faculty = new Faculty()
            {
                facultyName = facultyDTO.facultyName,
                IdFaculty = facultyDTO.IdFaculty,
                facultyAddress = facultyDTO.facultyAddress
             };

            Database.RFaculties.Create(faculty);
            await Database.Save();

            return new OperationDetails(true, "Registration success", "");
        }

        public async Task<OperationDetails> Update(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> Remove(int UserId)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {

        }

    }
}
