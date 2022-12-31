using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Complaints.Models
{
    public class Response
    {
        [Key]
        public int RespId { get; set; }

        public string RespText { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime RespDate { get; set; }

        #region Response-Complaint-Relation
        [ForeignKey("Complaint")]
        public int CompId { get; set; }

        public Complaint Complaint { get; set; }
        #endregion

        #region Response-ResponseType-Relation

        [ForeignKey("ResponseType")]
        public int RespTypeId { get; set; }
        public ResponseType ResponseType { get; set; }

        #endregion
    }
}
