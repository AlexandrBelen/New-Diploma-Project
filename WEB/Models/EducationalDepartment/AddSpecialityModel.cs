using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using BLL.DTO;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WEB.Models.EducationalDepartment
{
    public class AddSpecialityModel
    {
        public string Name_Speciality { get; set; }
        public string Code_Speciality { get; set; }
        public string Name_area { get; set; }

        public List<SelectListItem> newList { get; set; }
    }
}
