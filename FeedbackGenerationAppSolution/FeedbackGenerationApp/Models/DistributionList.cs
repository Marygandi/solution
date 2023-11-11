using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FeedbackGenerationApp.Models
{
    public class DistributionList
    {
        [Key]
        public int CustomerId { get; set; } // Primary Key
        public bool EmailOption { get; set; }
        public bool WhatsAppOption { get; set; }
        public string Role { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public User User { get; set; }
        public int Id { get; internal set; }
    }
}