using System.ComponentModel.DataAnnotations;

namespace Complaints.Models
{
    public class Area
    {
        [Key]
        public int AreaId { get; set; }

        public string AreaName { get; set; }

        public ICollection<Complaint> Complaints { get; set; }

        public Area()
        {
            Complaints = new HashSet<Complaint>();
        }
    }
}
