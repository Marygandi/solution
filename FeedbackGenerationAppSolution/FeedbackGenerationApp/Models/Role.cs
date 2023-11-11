namespace FeedbackGenerationApp.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public List<SurveyUserRoles> SurveyUserRoles { get; set; }

    }
}

