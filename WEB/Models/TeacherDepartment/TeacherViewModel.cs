using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB.Models
{
    public class TeacherViewModel
    {
        public int IdTeacher { get; set; }
        public int position { get; set; }
        public string salary { get; set; }
        public int rank { get; set; }
        public int academicTitle { get; set; }
        public byte staff { get; set; }
        public string employmentYear { get; set; }
        public string releaseYear { get; set; }
        public int teacherInfoId { get; set; }
    }
}
