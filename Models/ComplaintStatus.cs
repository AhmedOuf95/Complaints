using System.ComponentModel.DataAnnotations;

namespace Complaints.Models
{
    public class ComplaintStatus
    {
        [Key]

        public int CompStatusID { get; set; }

        [Required]
        public string CompStatusName { get; set;}
    }
}
