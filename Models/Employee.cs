using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Complaints.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }

        [Required]
        public string EmpName { get; set; }

        #region Employee-EmployeeComplaint-Relation

        public ICollection<EmployeeComplaint> EmployeeComplaints { get; set; }

        #endregion

        #region Employee-Department-Relation

        [ForeignKey("Department")]
        public int DeptId { get; set; }
        public Department Department { get; set; }

        #endregion

        #region Employee-JobTitle-Relation

        [ForeignKey("JobTitle")]
        public int JobTitId { get; set; }
        public JobTitle JobTitle { get; set; }

        #endregion

        #region Employee-Employee-Relation

        [ForeignKey("Employee")]
        public int? EmployeeId { get; set; }

        public ICollection<Employee> Employees { get; set; }

        #endregion


        public Employee()
        {
            EmployeeComplaints = new HashSet<EmployeeComplaint>();
            Employees = new HashSet<Employee>();
        }
    }
}
