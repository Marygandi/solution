using System.ComponentModel.DataAnnotations;

namespace FeedbackGenerationApp.Models
{
    public class SurveyTemplate
    {
        [Key]
        public int TemplateId { get; set; } // Primary Key
        public string TemplateName { get; set; }
        public string TemplateDescription { get; set; }

        public List<Survey> Surveys { get; set; }
        public int Id { get; internal set; }
    }
}