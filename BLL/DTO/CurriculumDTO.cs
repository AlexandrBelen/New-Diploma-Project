using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLL.DTO
{
    public class CurriculumDTO
    {
        public int Id_Curriculum { get; set; }
        public string NameEducationalDegree { get; set; }
        public string NameFaculty { get; set; }
        public string NameCathedra { get; set; }
        public string NameSpesialty { get; set; }
        public string NameKnowledgeArea { get; set; }
        public string NameSpecialization { get; set; }
        public string TrainingPeriod { get; set; }
        public string BasedOn { get; set; }
        public string Qualification { get; set; }
        public string NameForm_of_education { get; set; }
    }
}
