using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public partial class ClassroomType
    {
        [Key]
        public int IdType { get; set; }
        public string typeName { get; set; }
    }
}
