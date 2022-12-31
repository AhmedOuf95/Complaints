using System.ComponentModel.DataAnnotations;

namespace Complaints.Models
{
    public class Complaint
    {
        [Key]
        public int CompId { get; set; }

        [Required]
        public string CompText { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CompIssuedDate { get; set; }
    }
}
