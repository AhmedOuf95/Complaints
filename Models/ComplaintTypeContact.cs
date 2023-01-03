using System.ComponentModel.DataAnnotations.Schema;

namespace Complaints.Models
{
    public class ComplaintTypeContact
    {

        public int CompTypeContactID { get; set; }

        public string CompTypeContactName { get; set; }

        public int CompTypeContactPhone { get; set; }

        [ForeignKey("ComplaintType")]
        public int CompTypeId { get; set; }
        public ComplaintType ComplaintType { get; set; }
    }
}
