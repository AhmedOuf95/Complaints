using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        #region Complaint-Citizen-Relation (Many => 1)

        [ForeignKey("Citizen")]
        public int CtzId { get; set; }

        public Citizen Citizen { get; set; }

        #endregion
    }
}
