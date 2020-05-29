using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB.Models
{
    public class TeacherInfoViewModel
    {
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
