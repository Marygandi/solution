using FeedbackGenerationApp.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Survey
{
    [Key]
    public int SurveyId { get; set; } // Primary Key
    public string? SurveyName { get; set; }
    public int TemplateId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    [ForeignKey("TemplateId")]
    public SurveyTemplate Template { get; set; }

    [ForeignKey("CreatedByUserId")]
    public int CreatedByUserId { get; set; }
    public User CreatedBy { get; set; } // Navigation property to represent the creator
    public int RoleId { get; set; }

    public List<SurveyUserRoles> Roles { get; set; } // Navigation property to represent roles
    public object SurveyUserRoles { get; internal set; }
}