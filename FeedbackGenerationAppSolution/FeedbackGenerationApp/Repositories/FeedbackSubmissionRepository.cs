using FeedbackGenerationApp.Contexts;
using FeedbackGenerationApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

public class FeedbackSubmissionsRepository
{
    private readonly FeedbackContext _context;

    public FeedbackSubmissionsRepository(FeedbackContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<FeedbackSubmissions>> GetAllAsync()
    {
        return await _context.FeedbackSubmissions.ToListAsync();
    }

    public async Task<FeedbackSubmissions> GetByIdAsync(int id)
    {
        return await _context.FeedbackSubmissions.FindAsync(id);
    }

    public async Task AddAsync(FeedbackSubmissions feedbackSubmission)
    {
        _context.FeedbackSubmissions.Add(feedbackSubmission);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(FeedbackSubmissions feedbackSubmission)
    {
        _context.Entry(feedbackSubmission).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var feedbackSubmission = await _context.FeedbackSubmissions.FindAsync(id);
        if (feedbackSubmission != null)
        {
            _context.FeedbackSubmissions.Remove(feedbackSubmission);
            await _context.SaveChangesAsync();
        }
    }
}
