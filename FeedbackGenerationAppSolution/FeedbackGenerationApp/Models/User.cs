using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FeedbackGenerationApp.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; } // Auto-generated primary key
        public string? Username { get; set; }
        public byte[]? Password { get; set; }

        [InverseProperty("CreatedBy")]
        public List<Survey> SurveysCreated { get; set; }

        [InverseProperty("Role")]
        //public List<Survey> SurveysWithRole { get; set; }

        public byte[]? Key { get; set; }
        public object DistributionList { get; internal set; }
        public List<SurveyUserRoles> SurveysWithRole { get; set; } // Navigation property to represent surveys with a role
    }
}
