using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Faculty
    {
        [Key]
        public int IdFaculty { get; set; }
        public string facultyName { get; set; }
        public string facultyAddress { get; set; }
    }
}
