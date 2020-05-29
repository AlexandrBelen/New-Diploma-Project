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
    public class PlanEducationalProcessService : IPlanEducationalProcessService
    {
        private IUnitOfWork Database { get; set; }

        public PlanEducationalProcessService(IUnitOfWork uow)
        {
            Database = uow;
        }


        public IEnumerable<PlanEducationalProcessDTO> GetAllOneCurriculun(int id)
        {
            List<PlanEducationalProcess> newList = Database.RPlanEducationalProcess.GetAll().ToList().Where(x => x.ID_Curriculum == id).ToList();
            List<PlanEducationalProcessDTO> newList_ = new List<PlanEducationalProcessDTO>();

            for (int i = 0; i < newList.Count(); ++i)
            {
                newList_.Add(new PlanEducationalProcessDTO
                {
                    Semester = newList[i].Semester,
                    Course = newList[i].Course,
                    nameFormDelivery = Database.RFormDelivery.GetAll().ToList().Where(x => x.IdDelivery == newList[i].ID_FormDelivery).SingleOrDefault().NameDelivery,
                    nameUnderCycle = Database.RUnderCycle.GetAll().ToList().Where(x => x.IdUnderCycle == newList[i].ID_UnderCycle).SingleOrDefault().NameUnderCycle,
                    LectureHours = newList[i].LectureHours,
                    LaboratoryHours = newList[i].LaboratoryHours,
                    PracticesHours = newList[i].PracticesHours,
                    ID_Curriculm = id.ToString(),
                    NameDiscipline = newList[i].NameDiscipline,
                    Projects = newList[i].Projects,
                    IndependentWorkHours = newList[i].IndependentWorkHours,
                    nameCycle = newList[i].UnderCycle.Cycle.NameCycle, 
                    
                });

                newList_[i].AllHours = (Convert.ToInt32(newList_[i].LectureHours) + Convert.ToInt32(newList_[i].LaboratoryHours) + Convert.ToInt32(newList_[i].PracticesHours)).ToString();
                newList_[i].TotalHours = (Convert.ToInt32(newList_[i].AllHours) + Convert.ToInt32(newList_[i].IndependentWorkHours)).ToString();
                newList_[i].NumberECTS = (Convert.ToInt32(newList_[i].TotalHours) / (double)30).ToString();
            }

            return newList_;
        }

        public PlanEducationalProcessDTO FindPlanEducationalProcess(string name)
        {
            throw new Exception();
        }

        public async Task<OperationDetails> Create(PlanEducationalProcessDTO itemDTO)
        {
            PlanEducationalProcess newItem = new PlanEducationalProcess()
            {
                ID_Curriculum = Convert.ToInt32(itemDTO.ID_Curriculm),
                ID_FormDelivery = Database.RFormDelivery.Get(itemDTO.nameFormDelivery).IdDelivery,
                ID_UnderCycle = Database.RUnderCycle.Get(itemDTO.nameUnderCycle).IdUnderCycle,
                Course = itemDTO.Course,
                LaboratoryHours = itemDTO.LaboratoryHours,
                LectureHours = itemDTO.LectureHours,
                PracticesHours = itemDTO.PracticesHours,
                Projects = itemDTO.Projects,
                NameDiscipline = itemDTO.NameDiscipline,
                IndependentWorkHours = itemDTO.IndependentWorkHours,
                Semester = itemDTO.Semester,
            };

            Database.RPlanEducationalProcess.Create(newItem);
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
