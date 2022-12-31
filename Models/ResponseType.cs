using System.ComponentModel.DataAnnotations;

namespace Complaints.Models
{
    public class ResponseType
    {
        [Key]
        public int RespTypeId { get; set; }

        public string RespTypeName { get; set; }

        public ICollection<Response> Responses { get; set; }

        public ResponseType()
        {
            Responses = new HashSet<Response>();
        }
    }
}
