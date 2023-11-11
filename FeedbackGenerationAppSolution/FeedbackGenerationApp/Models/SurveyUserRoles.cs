using FeedbackGenerationApp.Models;
using System;
using System.Collections.Generic;

namespace FeedbackGenerationApp.Models
{
    public class SurveyUserRoles
    {
        public int SurveyId { get; set; }
        public Survey Survey { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }

        // Define Roles as a collection of Role entities
        public List<Role> Roles { get; set; }
    }
}





