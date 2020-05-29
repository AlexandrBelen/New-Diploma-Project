using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BLL.DTO;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WEB.Models.CurriculumDepartment
{
    public class AddCurriculumModel
    {
        public string nameEducationalDegree { get; set; }
        public string Qualification { get; set; }

        public string nameSpecialization { get; set; }
        public string TrainingPeriod { get; set; }

        public string nameForm_of_education { get; set; }
        public string BasedOn { get; set; }

        public List<SelectListItem> newListSpecialization { get; set; }
        public List<SelectListItem> newListEducationalDegree { get; set; }
        public List<SelectListItem> newListForm_of_education { get; set; }

        public List<SelectListItem> newKnowledgeArea { get; set; }
        public List<SelectListItem> newFaculty { get; set; }
        public List<SelectListItem> newListCathedra { get; set; }
    }
}
