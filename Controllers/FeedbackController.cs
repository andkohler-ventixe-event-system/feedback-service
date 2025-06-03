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
    public async Task<ActionResult<IEnumerable<Feedback>>> GetAll() => await context.Feedbacks.ToListAsync();

    [HttpGet("{id}")]
    public async Task<ActionResult<Feedback>> GetById(int id) => await context.Feedbacks.FindAsync(id) is Feedback feedback ? feedback : NotFound();

    [HttpPost]
    public async Task<ActionResult<Feedback>> Create(Feedback feedback)
    {
        context.Feedbacks.Add(feedback);
        await context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetById), new { id = feedback.Id }, feedback);
    }
}
