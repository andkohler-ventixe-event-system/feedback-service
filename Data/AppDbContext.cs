using FeedbackService.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FeedbackService.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Feedback> Feedbacks => Set<Feedback>();
}
