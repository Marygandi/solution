using FeedbackGenerationApp.Contexts;
using FeedbackGenerationApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

public class CustomerResponsesRepository
{
    private readonly FeedbackContext _context;

    public CustomerResponsesRepository(FeedbackContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<CustomerResponses>> GetAllAsync()
    {
        return await _context.CustomerResponses.ToListAsync();
    }

    public async Task<CustomerResponses> GetByIdAsync(int id)
    {
        return await _context.CustomerResponses.FindAsync(id);
    }

    public async Task AddAsync(CustomerResponses customerResponse)
    {
        _context.CustomerResponses.Add(customerResponse);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(CustomerResponses customerResponse)
    {
        _context.Entry(customerResponse).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var customerResponse = await _context.CustomerResponses.FindAsync(id);
        if (customerResponse != null)
        {
            _context.CustomerResponses.Remove(customerResponse);
            await _context.SaveChangesAsync();
        }
    }
}