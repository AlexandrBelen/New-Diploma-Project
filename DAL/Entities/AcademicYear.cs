using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public partial class AcademicYear
    {
        [Key]
        public int IdYear { get; set; }
        public string year { get; set; }
    }
}
