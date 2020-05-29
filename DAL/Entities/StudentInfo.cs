using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public partial class StudentInfo
    {
        [Key]
        public int stundtInfoID { get; set; }
        public string studentName { get; set; }
        public string studentMiddleName { get; set; }
        public string studentLastName { get; set; }
        public string bday { get; set; }
        public string phone { get; set; }
        public string homeAddress { get; set; }
        public string email { get; set; }
        public string studentSex { get; set; }
        public string StudentFirstParentName { get; set; }
        public string StudentFirstParentPhone { get; set; }
        public string StudentSecondParentName { get; set; }
        public string StudentSecondParentPhone { get; set; }
    }
}
