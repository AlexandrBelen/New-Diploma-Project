using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BLL.DTO
{
    public class StudentDTO
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
