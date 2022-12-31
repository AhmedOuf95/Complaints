using System.ComponentModel.DataAnnotations;

namespace Complaints.Models
{
    public class EmployeeCompNote
    {
        [Key]
        public int EmpCompNoteId { get; set; }

        public string EmpCompNote { get; set; }

    }
}
