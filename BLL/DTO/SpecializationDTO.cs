using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLL.DTO
{
    public class SpecializationDTO
    {
        public int ID_Specialization { get; set; }
        public string nameSpecialization { get; set; }
        public string Speciality { get; set; }
        public string nameCathedra { get; set; }
        public string nameFaculty { get; set; }
    }
}