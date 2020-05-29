using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class TeacherInfoDTO
    {
        public int teacherInfoId { get; set; }
        public string teacherName { get; set; }
        public string teacherMiddleName { get; set; }
        public string teacherLastName { get; set; }
        public string bday { get; set; }
        public string homeAddress { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public int basicEducation { get; set; }
        public int diploma { get; set; }
        public string trainingYear { get; set; }
        public string description { get; set; }
    }
}
