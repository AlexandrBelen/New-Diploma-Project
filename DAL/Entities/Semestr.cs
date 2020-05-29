using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public partial class Semestr
    {
        [Key]
        public int IdSemestr { get; set; }
        public string semestrNum { get; set; }
    }
}
