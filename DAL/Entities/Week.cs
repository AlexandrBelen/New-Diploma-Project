using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public partial class Week
    {
        [Key]
        public int IdWeek { get; set; }
        public string weekNumber { get; set; }
    }
}
