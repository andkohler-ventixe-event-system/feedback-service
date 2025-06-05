using System.ComponentModel.DataAnnotations;

namespace FeedbackService.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int Rating { get; set; }

        [Required]
        public string Comment { get; set; } = null!;

        [Required]
        public int EventId { get; set; }
    }
}
