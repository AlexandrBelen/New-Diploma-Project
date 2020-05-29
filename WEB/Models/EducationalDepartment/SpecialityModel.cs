using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BLL.DTO;

namespace WEB.Models.EducationalDepartment
{
    public class SpecialityModel
    {
        public List<SpecialityDTO> newList { get; set; }
    }
}
