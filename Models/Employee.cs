using System.ComponentModel.DataAnnotations;

namespace Complaints.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }

        [Required]
        public string EmpName { get; set; }

    }
}
