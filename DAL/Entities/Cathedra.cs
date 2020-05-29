using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Cathedra
    {
        [Key]
        public int IdCathedra { get; set; }

        public string cathedraName { get; set; }


        [ForeignKey("Faculty")]
        public int ID_faculty { get; set; }
       
        public virtual Faculty Faculty { get; set; }   
    }
}
