using System.ComponentModel.DataAnnotations;

namespace Complaints.Models
{
    public class ComplaintType
    {
        [Key]
        public int CompTypeId { get; set; }

        public string CompTypeName { get; set; }
    }
}
