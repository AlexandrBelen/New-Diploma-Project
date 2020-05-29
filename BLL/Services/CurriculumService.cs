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
    public class CurriculumService : ICurriculumService
    {
        private IUnitOfWork Database { get; set; }

        public CurriculumService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public IEnumerable<CurriculumDTO> GetAll()
        {
            List<Curriculum> newlist = Database.RCurriculum.GetAll().ToList();
            List<CurriculumDTO> newlistdto = new List<CurriculumDTO>();

            for (int i = 0; i < newlist.Count; ++i)
            {
                newlistdto.Add(new CurriculumDTO
                {
                    Id_Curriculum = newlist[i].IDCurriculum,
                    BasedOn = newlist[i].BasedOn,
                    Qualification = newlist[i].Qualification,
                    TrainingPeriod = newlist[i].TrainingPeriod,
                    NameCathedra = newlist[i].Specialization.Cathedra.cathedraName,
                    NameEducationalDegree = newlist[i].EducationalDegree.degreeName,
                    NameFaculty = newlist[i].Specialization.Cathedra.Faculty.facultyName,
                    NameForm_of_education = newlist[i].Form_of_education.Name,
                    NameSpecialization = newlist[i].Specialization.nameSpecialization,
                    NameSpesialty = newlist[i].Specialization.DirectorySpeciality.specialityName,
                    NameKnowledgeArea = newlist[i].Specialization.DirectorySpeciality.KnowledgeArea.areaName
                });
            }

            return newlistdto;
        }

        public CurriculumDTO FindCurriculum(string name)
        {
            Curriculum item = Database.RCurriculum.Get(name);
            CurriculumDTO DTO = null;

            if (item != null)
            {
                DTO = new CurriculumDTO();

                DTO.Id_Curriculum = item.IDCurriculum;
                DTO.BasedOn = item.BasedOn;
                DTO.Qualification = item.Qualification;
                DTO.TrainingPeriod = item.TrainingPeriod;
                DTO.NameCathedra = item.Specialization.Cathedra.cathedraName;
                DTO.NameEducationalDegree = item.EducationalDegree.degreeName;
                DTO.NameFaculty = item.Specialization.Cathedra.Faculty.facultyName;
                DTO.NameForm_of_education = item.Form_of_education.Name;
                DTO.NameSpecialization = item.Specialization.nameSpecialization;
                DTO.NameSpesialty = item.Specialization.DirectorySpeciality.specialityName;
                DTO.NameKnowledgeArea = item.Specialization.DirectorySpeciality.KnowledgeArea.areaName;
            }

            return DTO;
        }

        public async Task<OperationDetails> Create(CurriculumDTO DTO)
        {
            Curriculum newItem = new Curriculum()
            {
                BasedOn = DTO.BasedOn,
                Qualification = DTO.Qualification,
                TrainingPeriod = DTO.TrainingPeriod,
                ID_EducationalDegree = Database.REducationalDegree.GetAll().Where(x => x.degreeName == DTO.NameEducationalDegree).SingleOrDefault().IdDegree,
                ID_Form_of_education = Database.RFormEducation.GetAll().Where(x => x.Name == DTO.NameForm_of_education).SingleOrDefault().IdFormEducation,
                ID_Specialization = Database.RSpecialization.GetAll().Where(x => x.nameSpecialization == DTO.NameSpecialization).SingleOrDefault().ID_Specialization
            };

            Database.RCurriculum.Create(newItem);
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
