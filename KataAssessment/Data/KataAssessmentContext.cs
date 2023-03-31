using Microsoft.EntityFrameworkCore;

namespace KataAssessment.Data
{
    public class KataAssessmentContext : DbContext
    {
        public KataAssessmentContext(DbContextOptions<KataAssessmentContext> options)
            : base(options)
        {
        }

        public DbSet<KataAssessment.Models.User> User { get; set; }
    }
}
