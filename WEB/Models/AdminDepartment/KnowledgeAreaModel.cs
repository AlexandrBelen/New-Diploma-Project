using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BLL.DTO;

namespace WEB.Models.AdminDepartment
{
    public class KnowledgeAreaModel
    {
        public List<KnowledgeAreaDTO> newList { get; set; }
    }
}
