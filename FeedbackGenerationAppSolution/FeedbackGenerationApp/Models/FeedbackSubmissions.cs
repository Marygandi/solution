using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FeedbackGenerationApp.Models
{
    public class FeedbackSubmissions
    {
        [ForeignKey("ResponseId")]
        public int ResponseId { get; set; }
        public FeedbackResponses Response { get; set; }
        public DateTime SubmissionDate { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }
    }
}