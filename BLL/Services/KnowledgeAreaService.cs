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
    public class KnowledgeAreaService : IKnowledgeAreaService
    {
        private IUnitOfWork Database { get; set; }

        public KnowledgeAreaService(IUnitOfWork uow)
        {
            Database = uow;
        }


        public IEnumerable<KnowledgeAreaDTO> GetAll()
        {
            List<KnowledgeArea> newList = Database.RAreas.GetAll().ToList();
            List<KnowledgeAreaDTO> newListFacultyDTO = new List<KnowledgeAreaDTO>();

            for (int i = 0; i < newList.Count(); ++i)
            {
                newListFacultyDTO.Add(new KnowledgeAreaDTO
                {
                    IdArea = newList[i].IdArea,
                    areaName = newList[i].areaName,
                    areaCode = newList[i].areaCode
                });
            }

            return newListFacultyDTO;
        }

        public KnowledgeAreaDTO FindKnowledgeArea(string name)
        {
            KnowledgeArea item = Database.RAreas.Get(name);
            KnowledgeAreaDTO item_ = null;

            if (item != null)
            {
                item_ = new KnowledgeAreaDTO();

                item_.IdArea = item.IdArea;
                item_.areaName = item.areaName;
                item_.areaCode = item.areaCode;
            }

            return item_;
        }

        public async Task<OperationDetails> Create(KnowledgeAreaDTO newItem)
        {
            KnowledgeArea item_ = new KnowledgeArea()
            {
                IdArea = newItem.IdArea,
                areaName = newItem.areaName,
                areaCode = newItem.areaCode
            };

            Database.RAreas.Create(item_);
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
