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
    public class CathedraService : ICathedraService
    {
        private IUnitOfWork Database { get; set; }

        public CathedraService(IUnitOfWork uow)
        {
            Database = uow;
        }



        public IEnumerable<CathedraDTO> GetAll()
        {
            List<Cathedra> newList = Database.RCathedra.GetAll().ToList();
            List<CathedraDTO> newList_ = new List<CathedraDTO>();

            for (int i = 0; i < newList.Count(); ++i)
            {
                newList_.Add(new CathedraDTO
                {
                    Id_Cathedra = newList[i].IdCathedra,
                    cathedraName = newList[i].cathedraName,
                    facultyName = Database.RFaculties.GetAll().Where(x => x.IdFaculty == newList[i].ID_faculty).SingleOrDefault().facultyName
                });
            }

            return newList_;
        }

        public CathedraDTO FindCathedra(string name)
        {
            Cathedra item = Database.RCathedra.Get(name);
            CathedraDTO itemDTO = null;

            if (item != null)
            {
                itemDTO = new CathedraDTO();

                itemDTO.Id_Cathedra = item.IdCathedra;
                itemDTO.cathedraName = item.cathedraName;
                itemDTO.facultyName = Database.RCathedra.GetAll().Where(x => x.IdCathedra == item.IdCathedra).SingleOrDefault().cathedraName;
            }

            return itemDTO;
        }

        public async Task<OperationDetails> Create(CathedraDTO itemDTO)
        {
            Cathedra newItem = new Cathedra()
            {
                cathedraName = itemDTO.cathedraName,
                ID_faculty = Database.RFaculties.Get(itemDTO.facultyName).IdFaculty
            };

            Database.RCathedra.Create(newItem);
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
