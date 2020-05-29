using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEB.Models
{
    public class StudentInfoViewModel
    {
        public int studentInfoID { get; set; }
        [Required]
        [DataType("Name")]
        public string studentName { get; set; }
        public string studentMiddleName { get; set; }
        [Required]
        public string studentLastName { get; set; }
        [Required]
        public string bday { get; set; }
        [Required]
        public string phone { get; set; }
        [Required]
        public string homeAddress { get; set; }
        public string email { get; set; }
        [Required]
        public string studentSex { get; set; }
        [Required]
        public string StudentFirstParentName { get; set; }
        [Required]
        [Phone]
        public string StudentFirstParentPhone { get; set; }
        public string StudentSecondParentName { get; set; }
        public string StudentSecondParentPhone { get; set; }
    }
}
