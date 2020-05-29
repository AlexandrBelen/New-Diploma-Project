using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WEB.Views.Specialization
{
    public class GetItemsModel
    {
        public List<SelectListItem> newList { get; set; }
    }
}
