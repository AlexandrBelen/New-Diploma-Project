using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BLL.DTO;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WEB.Views.UnderCycle
{
    public class Add_UnderCycleModel
    {
        public string nameUnderCycle { get; set; }
        public string nameCycle { get; set; }

        public string Code { get; set; }

        public List<SelectListItem> newList { get; set; }
    }
}
