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
    public class FormEducationService : IFormEducationService
    {
        private IUnitOfWork Database { get; set; }

        public FormEducationService(IUnitOfWork uow)
        {
            Database = uow;
        }



        public IEnumerable<FormEducationDTO> GetAll()
        {
            List<Form_of_education> newList = Database.RFormEducation.GetAll().ToList();
            List<FormEducationDTO> newListDTO = new List<FormEducationDTO>();

            for (int i = 0; i < newList.Count(); ++i)
            {
                newListDTO.Add(new FormEducationDTO
                {
                    Id_FormEducation = newList[i].IdFormEducation,
                    FormEducationName = newList[i].Name
                });
            }

            return newListDTO;
        }

        public FormEducationDTO FindFormEducation(string name)
        {
            Form_of_education item = Database.RFormEducation.Get(name);
            FormEducationDTO DTO = null;

            if (item != null)
            {
                DTO = new FormEducationDTO();

                DTO.Id_FormEducation = item.IdFormEducation;
                DTO.FormEducationName = item.Name;
            }

            return DTO;
        }

        public async Task<OperationDetails> Create(FormEducationDTO DTO)
        {
            Form_of_education newItem = new Form_of_education()
            {
                Name = DTO.FormEducationName
            };

            Database.RFormEducation.Create(newItem);
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
