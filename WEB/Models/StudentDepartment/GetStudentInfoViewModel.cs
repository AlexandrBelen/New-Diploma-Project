using BLL.DTO;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB.Models.StudentDepartment
{
    public class GetStudentInfoViewModel: PageModel
    {
        public List<StudentInfoDTO> newList { get; set; }
    }
}
