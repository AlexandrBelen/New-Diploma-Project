using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public partial class Position
    {
        [Key]
        public int IdPosition { get; set; }
        public string positionName { get; set; }
    }
}
