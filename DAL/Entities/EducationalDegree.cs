using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public partial class EducationalDegree
    {
        [Key]
        public int IdDegree { get; set; }
        public string degreeName { get; set; }
    }
}
