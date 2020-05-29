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
    public class CycleService : ICycleService
    {
        private IUnitOfWork Database { get; set; }

        public CycleService(IUnitOfWork uow)
        {
            Database = uow;
        }



        public IEnumerable<CycleDTO> GetAll()
        {
            List<Cycle> newList = Database.RCycle.GetAll().ToList();
            List<CycleDTO> newListDTO = new List<CycleDTO>();

            for (int i = 0; i < newList.Count(); ++i)
            {
                newListDTO.Add(new CycleDTO
                {
                    Id_Cycle = newList[i].IdCycle,
                    CycleName = newList[i].NameCycle
                });
            }

            return newListDTO;
        }

        public CycleDTO FindCycle(string name)
        {
            Cycle item = Database.RCycle.Get(name);
            CycleDTO DTO = null;

            if (item != null)
            {
                DTO = new CycleDTO();

                DTO.Id_Cycle = item.IdCycle;
                DTO.CycleName= item.NameCycle;
            }

            return DTO;
        }

        public async Task<OperationDetails> Create(CycleDTO DTO)
        {
            Cycle newItem = new Cycle()
            {
                NameCycle = DTO.CycleName
            };

            Database.RCycle.Create(newItem);
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
