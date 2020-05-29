using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public partial class AcademicTitle
    {
        [Key]
        public int IdAcademicTitle { get; set; }
        public string academicTitleName { get; set; }
    }
}
