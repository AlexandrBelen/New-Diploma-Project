using BLL.DTO;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB.Views.StudentShtat
{
    public class Gruppa : PageModel
    {
        public List<GruppaDTO> newList { get; set; }
    }
}
