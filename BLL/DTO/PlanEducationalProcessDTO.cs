using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLL.DTO
{
    public class PlanEducationalProcessDTO
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
        public string nameCycle { get; set; }
    }
}
