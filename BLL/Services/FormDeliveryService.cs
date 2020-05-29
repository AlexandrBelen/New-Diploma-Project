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
    public class FormDeliveryService : IFormDeliveryService
    {
        private IUnitOfWork Database { get; set; }

        public FormDeliveryService(IUnitOfWork uow)
        {
            Database = uow;
        }



        public IEnumerable<FormDeliveryDTO> GetAll()
        {
            List<FormDelivery> newList = Database.RFormDelivery.GetAll().ToList();
            List<FormDeliveryDTO> newListDTO = new List<FormDeliveryDTO>();

            for (int i = 0; i < newList.Count(); ++i)
            {
                newListDTO.Add(new FormDeliveryDTO
                {
                    Id_FormDelivery = newList[i].IdDelivery,
                    FormDeliveryName = newList[i].NameDelivery
                });
            }

            return newListDTO;
        }

        public FormDeliveryDTO FindFormDelivery(string name)
        {
            FormDelivery item = Database.RFormDelivery.Get(name);
            FormDeliveryDTO DTO = null;

            if (item != null)
            {
                DTO = new FormDeliveryDTO();

                DTO.Id_FormDelivery = item.IdDelivery;
                DTO.FormDeliveryName = item.NameDelivery;
            }

            return DTO;
        }

        public async Task<OperationDetails> Create(FormDeliveryDTO DTO)
        {
            FormDelivery newItem = new FormDelivery()
            {
                NameDelivery = DTO.FormDeliveryName
            };

            Database.RFormDelivery.Create(newItem);
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
