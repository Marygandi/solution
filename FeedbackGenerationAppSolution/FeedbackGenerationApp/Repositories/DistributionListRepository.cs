using FeedbackGenerationApp.Contexts;
using FeedbackGenerationApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FeedbackGenerationApp.Repositories
{
    public class DistributionListRepository
    {
        private readonly FeedbackContext _context;

        public DistributionListRepository(FeedbackContext context)
        {
            _context = context;
        }

        public List<DistributionList> GetAllDistributionLists()
        {
            return _context.DistributionLists.ToList();
        }

        public DistributionList GetDistributionListById(int id)
        {
            return _context.DistributionLists.FirstOrDefault(dl => dl.Id == id);
        }

        // Add other methods as needed for your application
    }
}