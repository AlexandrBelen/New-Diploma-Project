using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BLL.DTO;

namespace WEB.Views.PlanEducationalProcess
{
    public class PlanEducationalProcesssModel
    {
        public List<CurriculumDTO> curriculum { get; set; }
    }
}
