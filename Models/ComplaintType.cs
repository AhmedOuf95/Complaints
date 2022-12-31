using System.ComponentModel.DataAnnotations;

namespace Complaints.Models
{
    public class ComplaintType
    {
        [Key]
        public int CompTypeId { get; set; }

        [Required]
        public string CompTypeName { get; set; }

        public ICollection<ComplaintTypeContact> ComplaintTypeContacts { get; set; }

        public ICollection<Complaint> Complaints { get; set; }

        public ComplaintType()
        {
            ComplaintTypeContacts= new HashSet<ComplaintTypeContact>();

            Complaints= new HashSet<Complaint>();
        }
    }
}
