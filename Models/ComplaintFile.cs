using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Complaints.Models
{
    public class ComplaintFile
    {
        [Key]
        public int CompFileId { get; set; }

        public byte file { get; set; }

        [ForeignKey("Complaint")]
        public int CompId { get; set; }
        public Complaint Complaint { get; set; }
    }
}
