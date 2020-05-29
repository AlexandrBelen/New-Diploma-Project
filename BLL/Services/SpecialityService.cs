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
    public class SpecialityService : ISpecialityService
    {
        private IUnitOfWork Database { get; set; }

        public SpecialityService(IUnitOfWork uow) => Database = uow;



        public IEnumerable<SpecialityDTO> GetAll()
        {
            List<DirectorySpeciality> newList = Database.RSpecialities.GetAll().ToList();
            List<SpecialityDTO> _newList = new List<SpecialityDTO>();

            for (int i = 0; i < newList.Count(); ++i)
            {
                _newList.Add(new SpecialityDTO
                {
                    Id = newList[i].IdSpeciality,
                    Name_Speciality = newList[i].specialityName,
                    Code_Speciality = newList[i].specialityCode,
                    KnowledgeAreaName = Database.RAreas.GetAll().Where(x => x.IdArea == newList[i].ID_KnowledgeArea).SingleOrDefault().areaName
                });
            }

            return _newList;
        }

        public SpecialityDTO FindSpeciality(string name)
        {
            DirectorySpeciality item = Database.RSpecialities.Get(name);
            SpecialityDTO _item = null;

            if (item != null)
            {
                _item = new SpecialityDTO();

                _item.Id = item.IdSpeciality;
                _item.Name_Speciality = item.specialityName;
                _item.Code_Speciality = item.specialityCode;
                _item.KnowledgeAreaName = Database.RAreas.GetAll().Where(x => x.IdArea == item.ID_KnowledgeArea).SingleOrDefault().areaName;
            }

            return _item;
        }

        public async Task<OperationDetails> Create(SpecialityDTO DTO)
        {
            DirectorySpeciality item = new DirectorySpeciality()
            {
                specialityName = DTO.Name_Speciality,
                specialityCode = DTO.Code_Speciality,
                ID_KnowledgeArea = Database.RAreas.Get(DTO.KnowledgeAreaName).IdArea
            };

            Database.RSpecialities.Create(item);
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
