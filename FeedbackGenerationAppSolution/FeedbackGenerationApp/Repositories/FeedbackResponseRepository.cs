using FeedbackGenerationApp.Contexts;
using FeedbackGenerationApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackGenerationApp.Repositories
{
    public class FeedbackResponsesRepository
    {
        private readonly FeedbackContext _context;

        public FeedbackResponsesRepository(FeedbackContext context)
        {
            _context = context;
        }

        public async Task<FeedbackResponses> GetFeedbackResponseByIdAsync(int responseId)
        {
            return await _context.FeedbackResponses.FindAsync(responseId);
        }

        // Implement methods for other CRUD operations
    }
}