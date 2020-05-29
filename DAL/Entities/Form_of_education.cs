using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Form_of_education
    {
        [Key]
        public int IdFormEducation { get; set; }
        public string Name { get; set; }
    }
}
