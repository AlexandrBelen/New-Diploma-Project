using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public partial class ParaNumber
    {
        [Key]
        public int IdPara { get; set; }
        public string paraTime { get; set; }
    }
}
