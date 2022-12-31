using System.ComponentModel.DataAnnotations;

namespace Complaints.Models
{
    public class ComplaintFile
    {
        [Key]
        public int CompFileId { get; set; }

        public byte file { get; set; }
    }
}
