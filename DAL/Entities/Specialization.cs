using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class Specialization
    {
        [Key]
        public int ID_Specialization { get; set; }
        public string nameSpecialization { get; set; }


        [ForeignKey("DirectorySpeciality")]
        public int ID_Speciality { get; set; }

        [ForeignKey("Cathedra")]
        public int ID_Cathedra { get; set; }

        public virtual DirectorySpeciality DirectorySpeciality { get; set; }
        public virtual Cathedra Cathedra { get; set; }
    }
}
