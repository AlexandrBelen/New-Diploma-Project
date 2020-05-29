using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class FormDelivery
    {
        [Key]
        public int IdDelivery { get; set; }
        public string NameDelivery { get; set; }
    }
}
