using FeedbackService.Data;
using FeedbackService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FeedbackService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FeedbackController(AppDbContext context) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Feedback>>> GetAll()
    {
        return await context.Feedbacks.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Feedback>> GetById(int id)
    {
        var feedback = await context.Feedbacks.FindAsync(id);
        if (feedback == null)
            return NotFound();

        return feedback;
    }

    [HttpPost]
    public async Task<ActionResult<Feedback>> Create(Feedback feedback)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        if (feedback.Date == default)
            feedback.Date = DateTime.UtcNow;

        context.Feedbacks.Add(feedback);
        await context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetById), new { id = feedback.Id }, feedback);
    }
}
