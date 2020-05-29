using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public partial class TeacherInfo
    {
        [Key]
        public int teacherInfoId { get; set; }
        public string teacherName { get; set; }
        public string teacherMiddleName { get; set; }
        public string teacherLastName { get; set; }
        public string bday { get; set; }
        public string homeAddress { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string trainingYear { get; set; }
        public string description { get; set; }
    }
}
