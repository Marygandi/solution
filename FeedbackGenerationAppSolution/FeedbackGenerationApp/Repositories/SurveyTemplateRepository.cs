using FeedbackGenerationApp.Contexts;
using FeedbackGenerationApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FeedbackGenerationApp.Repositories
{
    public class SurveyTemplateRepository
    {
        private readonly FeedbackContext _context;

        public SurveyTemplateRepository(FeedbackContext context)
        {
            _context = context;
        }

        public List<SurveyTemplate> GetAllSurveyTemplates()
        {
            return _context.SurveyTemplates.ToList();
        }

        public SurveyTemplate GetSurveyTemplateById(int id)
        {
            return _context.SurveyTemplates.FirstOrDefault(st => st.Id == id);
        }

        // Add other methods as needed for your application
    }
}