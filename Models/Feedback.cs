using System.ComponentModel.DataAnnotations;

namespace FeedbackService.Models;

public class Feedback
{
    public int Id { get; set; }

    [Required]
    public string EventTitle { get; set; } = null!;

    [Required]
    public string Category { get; set; } = null!;

    [Required]
    public int Rating { get; set; }

    [Required]
    public string Comment { get; set; } = null!;
}
