using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repositories
{
    public class CurriculumRepository : IRepositoryMain<Curriculum, string>
    {
        private ApplicationContext context;
        public CurriculumRepository(ApplicationContext applicationContext) => this.context = applicationContext;

        public void Create(Curriculum item)
        {
            context.Curriculums.Add(item);
        }

        public void Delete(string id)
        {
            throw new Exception();
        }

        public Curriculum Get(string id)
        {
            var _findItem = context.Curriculums.Where(p => p.IDCurriculum == Convert.ToInt32(id)).SingleOrDefault();

            if (_findItem != null)
            {
                _findItem.Specialization = context.Specializations.Where(p => p.ID_Specialization == _findItem.ID_Specialization).SingleOrDefault();
                _findItem.Specialization.DirectorySpeciality = context.DirectorySpecialitys.Where(p => p.IdSpeciality == _findItem.Specialization.ID_Speciality).SingleOrDefault();
                _findItem.Specialization.Cathedra = context.Cathedra.Where(p => p.IdCathedra == _findItem.Specialization.ID_Cathedra).SingleOrDefault();
                _findItem.Specialization.DirectorySpeciality.KnowledgeArea = context.KnowledgeAreas.Where(p => p.IdArea == _findItem.Specialization.DirectorySpeciality.ID_KnowledgeArea).SingleOrDefault();
                _findItem.Specialization.Cathedra.Faculty = context.Faculties.Where(p => p.IdFaculty == _findItem.Specialization.Cathedra.ID_faculty).SingleOrDefault();

                _findItem.EducationalDegree = context.EducationalDegrees.Where(p => p.IdDegree == _findItem.ID_EducationalDegree).SingleOrDefault();
                _findItem.Form_of_education = context.Form_Of_Educations.Where(p => p.IdFormEducation == _findItem.ID_Form_of_education).SingleOrDefault();
            }

            return _findItem;
        }

        public IEnumerable<Curriculum> GetAll()
        {
            List<Curriculum> newList = context.Curriculums.ToList();

            for (int i = 0; i < newList.Count; ++i)
            {
                newList[i].Specialization = context.Specializations.Where(p => p.ID_Specialization == newList[i].ID_Specialization).SingleOrDefault();
                newList[i].Specialization.DirectorySpeciality = context.DirectorySpecialitys.Where(p => p.IdSpeciality == newList[i].Specialization.ID_Speciality).SingleOrDefault();
                newList[i].Specialization.Cathedra = context.Cathedra.Where(p => p.IdCathedra == newList[i].Specialization.ID_Cathedra).SingleOrDefault();
                newList[i].Specialization.DirectorySpeciality.KnowledgeArea = context.KnowledgeAreas.Where(p => p.IdArea == newList[i].Specialization.DirectorySpeciality.ID_KnowledgeArea).SingleOrDefault();
                newList[i].Specialization.Cathedra.Faculty = context.Faculties.Where(p => p.IdFaculty == newList[i].Specialization.Cathedra.ID_faculty).SingleOrDefault();

                newList[i].EducationalDegree = context.EducationalDegrees.Where(p => p.IdDegree == newList[i].ID_EducationalDegree).SingleOrDefault();
                newList[i].Form_of_education = context.Form_Of_Educations.Where(p => p.IdFormEducation == newList[i].ID_Form_of_education).SingleOrDefault();
            }

            return newList;
        }

        public void Update(Curriculum item)
        {
            throw new Exception();
        }
    }
}