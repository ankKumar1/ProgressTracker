using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProgressTracker.Models;

namespace ProgressTracker.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<TaskItem> Tasks { get; set; }
        public DbSet<Habit> Habits { get; set; }

    }
}
