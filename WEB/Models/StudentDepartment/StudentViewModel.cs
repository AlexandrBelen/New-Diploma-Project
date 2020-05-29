using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace WEB.Models
{
    public class StudentViewModel
    {
        public int IdStudent { get; set; }
        public int gruppa { get; set; }
        public int speciality { get; set; }
        public string year { get; set; }
        public int cathedra { get; set; }
        public int faculty { get; set; }
        public int educationProgram { get; set; }
        public int studentInfo { get; set; }
    }
}
