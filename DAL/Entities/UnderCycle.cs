using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class UnderCycle
    {
        [Key]
        public int IdUnderCycle { get; set; }
        public string NameUnderCycle { get; set; }
        public string CodeUnderCycle { get; set; }

        [ForeignKey("Cycle")]
        public int ID_cycle { get; set; }
        
        public Cycle Cycle { get; set; }
    }
}
