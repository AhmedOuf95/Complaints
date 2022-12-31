using System.ComponentModel.DataAnnotations;

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
    }
}
