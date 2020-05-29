using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public partial class Shedule
    {
        [Key]
        public int IdShedule { get; set; }

        [ForeignKey("Teacher")]
        public Nullable<int> id_teacher { get; set; }

        [ForeignKey("Gruppa")]
        public int id_gruppa { get; set; }

        [ForeignKey("Disciplines")]
        public int id_discipline { get; set; }

        [ForeignKey("Week")]
        public int id_week { get; set; }

        [ForeignKey("DayOfWeek")]
        public int id_day { get; set; }

        [ForeignKey("ParaNumber")]
        public int id_para { get; set; }

        [ForeignKey("Classroom")]
        public int id_calssroom { get; set; }

        [ForeignKey("Semestr")]
        public int id_semestr { get; set; }

        [ForeignKey("AcademicYear")]
        public int id_year { get; set; }


        public virtual AcademicYear AcademicYear { get; set; }
        public virtual Classroom Classroom { get; set; }
        public virtual WeekDay DayOfWeek { get; set; }
        public virtual PlanEducationalProcess Disciplines { get; set; }
        public virtual Gruppa Gruppa { get; set; }
        public virtual ParaNumber ParaNumber { get; set; }
        public virtual Semestr Semestr { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Week Week { get; set; }
    }
}
