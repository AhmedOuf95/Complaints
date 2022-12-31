using System.ComponentModel.DataAnnotations;

namespace Complaints.Models
{
    public class Area
    {
        [Key]
        public int AreaId { get; set; }

        public string Name { get; set; }
    }
}
