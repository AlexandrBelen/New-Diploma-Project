using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB.Views.StudentShtat
{
    public class AddGruppa
    {
        public string Name { get; set; }
        //public int Starosta { get; set; }
        //public List<SelectListItem> newListStarosta { get; set; }
        public string Curator { get; set; }
        public List<SelectListItem> newListCurator { get; set; }
        public string Education { get; set; }
        public List<SelectListItem> newListEducation { get; set; }
        public string Cathedra { get; set; }
        public List<SelectListItem> newListCathedra { get; set; }
        public string Year { get; set; }
        public string EducLevel { get; set; }
        public List<SelectListItem> newList { get; set; }
    }
}
