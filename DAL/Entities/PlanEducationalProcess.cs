using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public partial class PlanEducationalProcess
    {
        [Key]
        public int ID_PlanEducationalProcess { get; set; }

        public string NameDiscipline { get; set; }
        public string Semester { get; set; }
        public string Projects { get; set; }
        public string Course { get; set; }
        public string LectureHours { get; set; }
        public string PracticesHours { get; set; }
        public string LaboratoryHours { get; set; }
        public string IndependentWorkHours { get; set; }


        [ForeignKey("Curriculum")]
        public int ID_Curriculum { get; set; }

        [ForeignKey("UnderCycle")]
        public int ID_UnderCycle { get; set; }

        [ForeignKey("FormDelivery")]
        public int ID_FormDelivery { get; set; }

        public UnderCycle UnderCycle { get; set; }
        public FormDelivery FormDelivery { get; set; }
    }
}
