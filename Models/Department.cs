using System.ComponentModel.DataAnnotations;

namespace Complaints.Models
{
    public class Department
    {
        [Key]

        public int DeptId { get; set; }

        [Required]
        public string DeptName { get; set; }
    }
}
