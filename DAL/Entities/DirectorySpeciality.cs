using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public partial class DirectorySpeciality
    {
        [Key]
        public int IdSpeciality { get; set; }
        public string specialityName { get; set; }
        public string specialityCode { get; set; }
    
        [ForeignKey("KnowledgeArea")]
        public int ID_KnowledgeArea { get; set; }
        public virtual KnowledgeArea KnowledgeArea { get; set; }
    }
}
