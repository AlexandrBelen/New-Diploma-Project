﻿using System;
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
    public class AddSpecializationModel
    {
        public string nameSpecialization { get; set; }
        public string nameSpeciality { get; set; }
        public string nameCathedra { get; set; }
        public string nameFaculty { get; set; }

        public List<SelectListItem> newListFaculty { get; set; }
        public List<SelectListItem> newListCathedra { get; set; }
        public List<SelectListItem> newListSpeciality { get; set; }
    }
}
