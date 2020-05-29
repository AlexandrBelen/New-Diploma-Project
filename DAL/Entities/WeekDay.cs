using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public partial class WeekDay
    {
        [Key]
        public int IdDay { get; set; }
        public string dayName { get; set; }
    }
}
