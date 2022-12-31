using Azure;
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

        #region Complaint-Area-Relation (Many => 1)

        [ForeignKey("Area")]
        public int AreaId { get; set; }

        public Area Area { get; set; }

        #endregion

        #region Complaint-ComplaintStatus-Relation (Many => 1)

        [ForeignKey("ComplaintStatus")]
        public int CompStatusID { get; set; }

        public ComplaintStatus ComplaintStatus { get; set; }

        #endregion

        #region Complaint-Response (1 => Many)

        public ICollection<Response> Responses { get; set; }

        #endregion

        #region Complaint-ComplaintType-Relation
        
        [ForeignKey("ComplaintType")]
        public int CompTypeId { get; set; }
        public ComplaintType ComplaintType { get; set; }

        #endregion

        #region EmployeeCompNote-Complaint-rel
        [ForeignKey("EmployeeCompNote")]
        public int? EmpCompNoteId { get; set; }
        public EmployeeCompNote EmployeeCompNote { get; set; }
        #endregion

        #region Complaint-ComplaintFile-Relation

        public ICollection<ComplaintFile> ComplaintFiles { get; set; }

        #endregion

        public ICollection<EmployeeComplaint> EmployeeComplaints { get; set; }

        public Complaint()
        {
            Responses = new HashSet<Response>();
            EmployeeComplaints = new HashSet<EmployeeComplaint>();
            ComplaintFiles= new HashSet<ComplaintFile>();
        }
    }
}
