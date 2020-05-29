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
    public class EducationalDegreeService : IEducationalDegreeService
    {
        private IUnitOfWork Database { get; set; }

        public EducationalDegreeService(IUnitOfWork uow)
        {
            Database = uow;
        }



        public IEnumerable<EducationalDegreeDTO> GetAll()
        {
            List<EducationalDegree> newList = Database.REducationalDegree.GetAll().ToList();
            List<EducationalDegreeDTO> newListDTO = new List<EducationalDegreeDTO>();

            for (int i = 0; i < newList.Count(); ++i)
            {
                newListDTO.Add(new EducationalDegreeDTO
                {
                    Id_EducationalDegree = newList[i].IdDegree,
                    EducationalDegreeName = newList[i].degreeName
                });
            }

            return newListDTO;
        }

        public EducationalDegreeDTO FindEducationalDegree(string name)
        {
            EducationalDegree item = Database.REducationalDegree.Get(name);
            EducationalDegreeDTO DTO = null;

            if (item != null)
            {
                DTO = new EducationalDegreeDTO();

                DTO.Id_EducationalDegree = item.IdDegree;
                DTO.EducationalDegreeName = item.degreeName;
            }

            return DTO;
        }

        public async Task<OperationDetails> Create(EducationalDegreeDTO DTO)
        {
            EducationalDegree newItem = new EducationalDegree()
            {
                degreeName = DTO.EducationalDegreeName
            };

            Database.REducationalDegree.Create(newItem);
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
