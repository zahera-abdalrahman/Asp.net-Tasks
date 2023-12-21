using System.ComponentModel.DataAnnotations;
using static Humanizer.On;

namespace EmployeeSystem.Models
{
    public class Feedback
    {
        [Key]
        public int FeedbackId { get; set; }

        public string SenderName { get; set; }

        public string SenderEmail { get; set; }

        public string FeedbackContent { get; set; }

        public int EmployeeID { get; set; }

        public Employee Employee { get; set; }
    }
}
