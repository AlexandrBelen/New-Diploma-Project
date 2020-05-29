using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public partial class Gruppa
    {
        [Key]
        public int IdGruppa { get; set; }
        public string gruppaName { get; set; }

        [ForeignKey("Teacher")]
        public int id_curator { get; set; }

        [ForeignKey("Form_of_education")]
        public int id_formOfEducation { get; set; }

        [ForeignKey("Cathedra")]
        public int id_cathedra { get; set; }

        public string year { get; set; }
        [ForeignKey("EducationalDegree")]
        public int educLevel { get; set; }


        public virtual Cathedra Cathedra { get; set; }
        public virtual Form_of_education Form_of_education { get; set; }
        public virtual Teacher Teacher { get; set; }

        public virtual EducationalDegree EducationalDegree { get; set; }
    }
}
