using System.ComponentModel.DataAnnotations;

namespace Complaints.Models
{
    public class Citizen
    {
        [Key]
        public int CtzId { get; set; }

        [Required,MaxLength(14)]
        public int SSN { get; set; }

        [Required,MaxLength(150)]
        public string CtzName { get; set; }
        
        [Required,MaxLength(150)]
        public string CtzAddress { get; set; }

        [DataType(DataType.EmailAddress)]
        public string CtzEmail { get; set; }

        [Required]
        public int CtzPhoneNumber { get; set; }
    }
}
