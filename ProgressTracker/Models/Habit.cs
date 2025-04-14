using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProgressTracker.Models
{
    public class Habit
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public required string Name { get; set; }

        [Range(0, int.MaxValue)]
        public int Streak { get; set; }

        public DateTime? LastCompletedDate { get; set; }

        public required string UserId { get; set; }

        [ForeignKey("UserId")]
        public required User User { get; set; }
    }
}
