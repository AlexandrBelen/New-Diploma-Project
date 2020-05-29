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
    public class SpecializationService : ISpecializationService
    {
        private IUnitOfWork Database { get; set; }

        public SpecializationService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public IEnumerable<SpecializationDTO> GetAll()
        {
            List<Specialization> newList = Database.RSpecialization.GetAll().ToList();
            List<SpecializationDTO> newList_ = new List<SpecializationDTO>();

            for (int i = 0; i < newList.Count(); ++i)
            {
                newList_.Add(new SpecializationDTO
                {
                    ID_Specialization = newList[i].ID_Specialization,
                    nameSpecialization = newList[i].nameSpecialization,
                    Speciality = Database.RSpecialities.GetAll().Where(x => x.IdSpeciality == newList[i].ID_Speciality).SingleOrDefault().specialityName,
                    nameCathedra = Database.RCathedra.GetAll().Where(x => x.IdCathedra == newList[i].ID_Cathedra).SingleOrDefault().cathedraName,
                    nameFaculty = Database.RFaculties.GetAll().Where(x => x.IdFaculty == 
                        Database.RCathedra.GetAll().Where(x => x.IdCathedra == newList[i].ID_Cathedra).SingleOrDefault().ID_faculty).SingleOrDefault().facultyName,
                });
            }

            return newList_;
        }

        public SpecializationDTO FindSpecialization(string name)
        {
            Specialization item = Database.RSpecialization.Get(name);
            SpecializationDTO itemDTO = null;

            if (item != null)
            {
                itemDTO = new SpecializationDTO();

                itemDTO.ID_Specialization = item.ID_Specialization;
                itemDTO.nameSpecialization = item.nameSpecialization;

                itemDTO.Speciality = Database.RSpecialities.GetAll().Where(x => x.IdSpeciality == item.ID_Speciality).SingleOrDefault().specialityName;
                itemDTO.nameCathedra = Database.RCathedra.GetAll().Where(x => x.IdCathedra == item.ID_Cathedra).SingleOrDefault().cathedraName;
                itemDTO.nameFaculty = Database.RFaculties.GetAll().Where(x => x.IdFaculty ==
                    Database.RCathedra.GetAll().Where(x => x.IdCathedra == item.ID_Cathedra).SingleOrDefault().ID_faculty).SingleOrDefault().facultyName;
            }

            return itemDTO;
        }

        public async Task<OperationDetails> Create(SpecializationDTO itemDTO)
        {
            Specialization newItem = new Specialization()
            {
                nameSpecialization = itemDTO.nameSpecialization,
                ID_Speciality = Database.RSpecialities.Get(itemDTO.Speciality).IdSpeciality,
                ID_Cathedra = Database.RCathedra.Get(itemDTO.nameCathedra).IdCathedra,
            };

            Database.RSpecialization.Create(newItem);
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
