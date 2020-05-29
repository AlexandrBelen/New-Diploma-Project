using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public partial class Student
    {
        [Key]
        public int stundentID { get; set; }

        [ForeignKey("Gruppa")]
        public Nullable<int> id_gruppa { get; set; }

        [ForeignKey("DirectorySpeciality")]
        public int id_speciality { get; set; }
        public string startYear { get; set; }
        public string year { get; set; }

        [ForeignKey("Cathedra")]
        public int id_cathedra { get; set; }

        [ForeignKey("Faculty")]
        public int id_faculty { get; set; }

        public int educationProgram { get; set; }

        [ForeignKey("StudentInfo")]
        public int id_studentInfo { get; set; }


        public virtual Cathedra Cathedra { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual Gruppa Gruppa { get; set; }
        public virtual StudentInfo StudentInfo { get; set; }
        public virtual DirectorySpeciality DirectorySpeciality { get; set; }

        //public virtual EducationProgram EducationProgram1 { get; set; }
    }
}
