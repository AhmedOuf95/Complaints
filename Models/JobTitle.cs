using System.ComponentModel.DataAnnotations;

namespace Complaints.Models
{
    public class JobTitle
    {
        [Key]
        public int JobTitleId { get; set; }

        [Required]
        public string JobTitleName { get; set; }
    }
}
