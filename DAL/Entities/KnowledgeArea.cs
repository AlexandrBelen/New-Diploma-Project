using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class KnowledgeArea
    {
        [Key]
        public int IdArea { get; set; }
        public string areaName { get; set; }
        public string areaCode { get; set; }
    }
}
