using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FeedbackGenerationApp.Models
{
    public class CustomerResponses
    {
        [Key]
        public int CustomerResponseId { get; set; }

        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        public int QuestionId { get; set; }
        public FeedbackQuestions Question { get; set; }

        public string? CustomerResponse { get; set; }
    }
}