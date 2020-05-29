using BLL.DTO;
using BLL.Infrastructure;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class GruppaService : IGruppaService
    {
        private IUnitOfWork Database { get; set; }

        public GruppaService(IUnitOfWork uow) => Database = uow;
        public Task ChangeInformation(GruppaDTO gruppaDTO)
        {
            Gruppa gruppa = Database.RGruppas.Get(gruppaDTO.name);
            if (gruppa == null) throw new ValidationException("this gruppa doesn't exist", gruppaDTO.name);
            throw new NotImplementedException();
        }

        public async Task<OperationDetails> CreateGruppa(GruppaDTO gruppaDTO)
        {
            Gruppa gruppa = new Gruppa()
            {
                gruppaName = gruppaDTO.name,
                id_cathedra = Database.RCathedra.Get(gruppaDTO.cathedra).IdCathedra,
                id_curator = Database.RTeachers.Get(gruppaDTO.curator).teacherInfoId,
                id_formOfEducation = Database.RFormEducation.Get(gruppaDTO.education).IdFormEducation,
                educLevel = Database.REducationalDegree.Get(gruppaDTO.educDegreeDTO).IdDegree,
                //starosta = gruppaDTO.starosta,
                year = gruppaDTO.year
            };
            Database.RGruppas.Create(gruppa);
            await Database.Save();
            return new OperationDetails(true, "Gruppa success", "");
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public GruppaDTO FindGruppa(string gruppaName)
        {
            Gruppa gruppa = Database.RGruppas.Get(gruppaName);
            GruppaDTO gruppaDTO = null;
            if (gruppa != null)
            {
                gruppaDTO = new GruppaDTO();
                gruppaDTO.name = gruppa.gruppaName;
                //gruppaDTO.curator = gruppa.id_curator;
                //gruppaDTO.starosta = gruppa.starosta;
                gruppaDTO.year = gruppa.year;
                //gruppaDTO.education = gruppa.id_formOfEducation;
                gruppaDTO.educDegreeDTO = Database.REducationalDegree.GetAll().Where(x => x.IdDegree == gruppa.educLevel).SingleOrDefault().degreeName;
            }
            return gruppaDTO;
        }

        public IEnumerable<GruppaDTO> GetGruppas()
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> RemoveGruppa(int gruppaId)
        {
            throw new NotImplementedException();
        }
    }
}
