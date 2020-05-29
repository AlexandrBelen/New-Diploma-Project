using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Curriculum
    {
        [Key]
        public int IDCurriculum { get; set; }

        [ForeignKey("EducationalDegree")]
        public int ID_EducationalDegree { get; set; }
        public string Qualification { get; set; }

        [ForeignKey("Specialization")]
        public int ID_Specialization { get; set; }
        public string TrainingPeriod { get; set; }

        [ForeignKey("Form_of_education")]
        public int ID_Form_of_education { get; set; }
        public string BasedOn { get; set; }

        public EducationalDegree EducationalDegree { get; set; }
        public Specialization Specialization { get; set; }
        public Form_of_education Form_of_education { get; set; }
    }
}
