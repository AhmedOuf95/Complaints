using System.ComponentModel.DataAnnotations;

namespace Complaints.Models
{
    public class ResponseType
    {
        [Key]
        public int RespTypeId { get; set; }

        public string RespTypeName { get; set; }
    }
}
