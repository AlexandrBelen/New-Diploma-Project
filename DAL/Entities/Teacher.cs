using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public partial class Teacher
    {
        [Key]
        public int idTeacher { get; set; }

        [ForeignKey("Position")]
        public int id_position { get; set; }
        public string salary { get; set; }

        [ForeignKey("Rank")]
        public int id_rank { get; set; }

        [ForeignKey("AcademicTitle")]
        public int id_academicTitle { get; set; }

        public byte staff { get; set; }
        public string employmentYear { get; set; }
        public string releaseYear { get; set; }

        [ForeignKey("TeacherInfo")]
        public int teacherInfoId { get; set; }


        public virtual Position Position { get; set; }
        public virtual Rank Rank { get; set; }
        public virtual AcademicTitle AcademicTitle { get; set; }
        public virtual TeacherInfo TeacherInfo { get; set; }
    }
}
