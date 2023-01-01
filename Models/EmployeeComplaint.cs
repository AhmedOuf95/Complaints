using System.ComponentModel.DataAnnotations.Schema;

namespace Complaints.Models
{
    public class EmployeeComplaint
    {
        [ForeignKey("Employee")]
        public int EmpId { get; set; }

        [ForeignKey("Complaint")]
        public int CompId { get; set; }

        public Complaint Complaint { get; set; }

        public Employee Employee { get; set; }
    }
}
