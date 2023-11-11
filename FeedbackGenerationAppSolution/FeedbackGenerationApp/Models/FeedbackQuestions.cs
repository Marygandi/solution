using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FeedbackGenerationApp.Models
{
    public class FeedbackQuestions
    {
        [Key]
        public int QuestionId { get; set; } // Primary Key
        public string? QuestionText { get; set; }
        public string? QuestionType { get; set; }
        public List<string>? Options { get; set; }

        [ForeignKey("SurveyId")]
        public int SurveyId { get; set; }
        public Survey Survey { get; set; }
    }
}