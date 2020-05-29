using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public partial class Cycle
    {
        [Key]
        public int IdCycle { get; set; }
        public string NameCycle { get; set; }
    }
}
