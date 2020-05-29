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
    public class UnderCycleService : IUnderCycleService
    {
        private IUnitOfWork Database { get; set; }

        public UnderCycleService(IUnitOfWork uow)
        {
            Database = uow;
        }



        public IEnumerable<UnderCycleDTO> GetAll()
        {
            List<UnderCycle> newList = Database.RUnderCycle.GetAll().ToList();
            List<UnderCycleDTO> newListDTO = new List<UnderCycleDTO>();

            for (int i = 0; i < newList.Count(); ++i)
            {
                newListDTO.Add(new UnderCycleDTO
                {
                    Id_UnderCycle = newList[i].IdUnderCycle,
                    UnderCycleName = newList[i].NameUnderCycle,
                    Code = newList[i].CodeUnderCycle,
                    CycleName = Database.RCycle.GetAll().Where(x => x.IdCycle == newList[i].ID_cycle).SingleOrDefault().NameCycle
                });
            }

            return newListDTO;
        }

        public UnderCycleDTO FindUnderCycle(string name)
        {
            UnderCycle item = Database.RUnderCycle.Get(name);
            UnderCycleDTO DTO = null;

            if (item != null)
            {
                DTO = new UnderCycleDTO();

                DTO.Id_UnderCycle = item.IdUnderCycle;
                DTO.UnderCycleName = item.NameUnderCycle;
                DTO.Code = item.CodeUnderCycle;
                DTO.CycleName = Database.RCycle.GetAll().Where(x => x.IdCycle == item.ID_cycle).SingleOrDefault().NameCycle;
            }

            return DTO;
        }

        public async Task<OperationDetails> Create(UnderCycleDTO DTO)
        {
            UnderCycle newItem = new UnderCycle()
            {
                NameUnderCycle = DTO.UnderCycleName,
                CodeUnderCycle = DTO.Code,
                ID_cycle = Database.RCycle.Get(DTO.CycleName).IdCycle
            };

            Database.RUnderCycle.Create(newItem);
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
