using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public partial class Rank
    {
        [Key]
        public int IdRank { get; set; }
        public string rankName { get; set; }
        public string rankDesc { get; set; }
    }
}
