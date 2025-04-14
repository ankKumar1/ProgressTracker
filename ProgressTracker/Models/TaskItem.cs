using ProgressTracker.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TaskStatus = ProgressTracker.Enums.TaskStatus;

namespace ProgressTracker.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public required string Title { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        [Required]
        public Priority Priority { get; set; }

        [Required]
        public TaskStatus Status { get; set; }

        [Required]
        public DateTime DueDate { get; set; }
        public required string UserId { get; set; }

        [ForeignKey("UserId")]
        public required User User { get; set; }
    }
}
