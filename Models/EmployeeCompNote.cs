using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Complaints.Models
{
    public class EmployeeCompNote
    {
        [Key]
        public int EmpCompNoteId { get; set; }

        public string EmpCompNote { get; set; }

        [ForeignKey("Complaint")]
        public int? CompId { get; set; }
        public Complaint Complaint { get; set; }
    }
}
