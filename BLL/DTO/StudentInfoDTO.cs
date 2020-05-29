using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class StudentInfoDTO
    {
        public int studentInfoID { get; set; }
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
