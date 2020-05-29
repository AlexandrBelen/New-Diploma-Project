using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class Role
    {
        [Key]
        public int ID_role { get; set; }
        public string Name { get; set; }
    }
}
