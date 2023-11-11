using FeedbackGenerationApp.Contexts;
using FeedbackGenerationApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

public class FeedbackQuestionsRepository
{
    private readonly FeedbackContext _context;

    public FeedbackQuestionsRepository(FeedbackContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<FeedbackQuestions>> GetAllAsync()
    {
        return await _context.FeedbackQuestions.ToListAsync();
    }

    public async Task<FeedbackQuestions> GetByIdAsync(int id)
    {
        return await _context.FeedbackQuestions.FindAsync(id);
    }

    public async Task AddAsync(FeedbackQuestions feedbackQuestion)
    {
        _context.FeedbackQuestions.Add(feedbackQuestion);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(FeedbackQuestions feedbackQuestion)
    {
        _context.Entry(feedbackQuestion).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var feedbackQuestion = await _context.FeedbackQuestions.FindAsync(id);
        if (feedbackQuestion != null)
        {
            _context.FeedbackQuestions.Remove(feedbackQuestion);
            await _context.SaveChangesAsync();
        }
    }
}
