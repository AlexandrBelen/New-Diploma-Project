using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public partial class Classroom
    {
        [Key]
        public int IdClassroom { get; set; }
        public string classroomNum { get; set; }

        [ForeignKey("ClassroomType")]
        public int id_classroomType { get; set; }
        public string amount { get; set; }
        public string description { get; set; }


        public virtual ClassroomType ClassroomType { get; set; }
    }
}
