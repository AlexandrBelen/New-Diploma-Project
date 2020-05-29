using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WEB.Views.PlanEducationalProcess
{
    public class Add_PlanEducationalProcessModel
    {
        public string ID_Curriculm { get; set; }
        public string NameDiscipline { get; set; }
        public string Semester { get; set; }
        public string nameFormDelivery { get; set; }
        public string Projects { get; set; }
        public string Course { get; set; }
        public string LectureHours { get; set; }
        public string PracticesHours { get; set; }
        public string LaboratoryHours { get; set; }
        public string AllHours { get; set; }
        public string IndependentWorkHours { get; set; }
        public string TotalHours { get; set; }
        public string NumberECTS { get; set; }
        public string nameUnderCycle { get; set; }

        public List<SelectListItem> newListIdCurriculm { get; set; }
        public List<SelectListItem> newListUnderCycle { get; set; }
        public List<SelectListItem> newListFormDelivery { get; set; }
    }
}
