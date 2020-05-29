using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BLL.DTO;

namespace WEB.Views.UnderCycle
{
    public class UnderCyclesModel
    {
        public List<UnderCycleDTO> newList { get; set; }
    }
}
