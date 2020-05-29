using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public partial class BasicEducation
    {
        [Key]
        public int IdBasicEducation { get; set; }
        [ForeignKey("TeacherInfo")]
        public int id_teacherInfo { get; set; }
        public string place { get; set; }
        public string years { get; set; }

        [ForeignKey("DirectorySpeciality")]
        public int id_speciality { get; set; }
        public int qualification { get; set; }

        public virtual DirectorySpeciality DirectorySpeciality { get; set; }
        public virtual TeacherInfo TeacherInfo { get; set; }

        //public virtual Qualification Qualification { get; set; }
    }
}
