using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public partial class TotalLoad
    {
        [Key]
        public int IdTotalLoad { get; set; }

        [ForeignKey("Teacher")]
        public int id_teacher { get; set; }

        [ForeignKey("Semestr")]
        public int semester { get; set; }

        public string amountOfDiscipline { get; set; }
        public string totalHours { get; set; }
        public string lectures { get; set; }
        public string practices { get; set; }
        public string labs { get; set; }
        public string tutoring { get; set; }
        public string exams { get; set; }
        public string credits { get; set; }
        public string controlWorks { get; set; }
        public string courseProjects { get; set; }
        public string budgetGroup { get; set; }
        public string bugetGroupPractice { get; set; }
        public string budgetGroupsLabs { get; set; }
        public string contractGroup { get; set; }
        public string contactGroupPractice { get; set; }
        public string contractGroupLabs { get; set; }
        public string studentsAmount { get; set; }

        public virtual Semestr Semestr { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
