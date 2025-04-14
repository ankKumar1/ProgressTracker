using Microsoft.AspNetCore.Identity;

namespace ProgressTracker.Models
{
    public class User : IdentityUser
    {
        public List<TaskItem>? Tasks { get; set; }
        public List<Habit>? Habits { get; set; }
    }
}
