using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using BLL.DTO;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WEB.Models.AdminDepartment
{
    public class AddEducationalDegreeModel
    {
        public string nameEducationalDegree { get; set; }
    }
}
