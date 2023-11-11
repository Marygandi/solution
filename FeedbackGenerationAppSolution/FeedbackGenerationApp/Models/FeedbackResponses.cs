using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FeedbackGenerationApp.Models
{
    public class FeedbackResponses
    {
        [Key]
        public int ResponseId { get; set; } // Primary Key

        [ForeignKey("QuestionId")]
        public int QuestionId { get; set; }
        public FeedbackQuestions Question { get; set; }

        public string? ResponseText { get; set; }
        public string? Status { get; set; }
    }
}