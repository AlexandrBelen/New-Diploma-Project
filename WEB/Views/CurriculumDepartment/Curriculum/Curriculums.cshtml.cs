using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BLL.DTO;

namespace WEB.Views.Curriculum
{
    public class CurriculumsModel
    {
        public List<CurriculumDTO> newList { get; set; }
    }
}
