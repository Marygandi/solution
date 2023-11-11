using FeedbackGenerationApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FeedbackGenerationApp.Contexts
{
    public class FeedbackContext : DbContext
    {
        public FeedbackContext(DbContextOptions<FeedbackContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<SurveyTemplate> SurveyTemplates { get; set; }
        public DbSet<FeedbackQuestions> FeedbackQuestions { get; set; }
        public DbSet<FeedbackResponses> FeedbackResponses { get; set; }
        public DbSet<DistributionList> DistributionLists { get; set; }
        public DbSet<CustomerResponses> CustomerResponses { get; set; }
        public DbSet<FeedbackSubmissions> FeedbackSubmissions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define relationships between entities

            // Define a one-to-many relationship between Survey and SurveyTemplate
            modelBuilder.Entity<Survey>()
                .HasOne(s => s.Template)
                .WithMany()
                .HasForeignKey(s => s.TemplateId);

            // Define a one-to-one relationship between Survey and User for CreatedBy
            modelBuilder.Entity<Survey>()
                .HasOne(s => s.CreatedBy)
                .WithMany(u => u.SurveysCreated)
                .HasForeignKey(s => s.CreatedByUserId);

            // Define a many-to-many relationship between Survey and Role through SurveyUserRoles
            modelBuilder.Entity<Survey>()
               .HasOne(s => s.Template)
               .WithMany()
               .HasForeignKey(s => s.TemplateId);

            // Define a one-to-one relationship between Survey and User for CreatedBy
            modelBuilder.Entity<Survey>()
                .HasOne(s => s.CreatedBy)
                .WithMany()
                .HasForeignKey(s => s.CreatedByUserId);
//
            modelBuilder.Entity<Survey>()
     .HasMany(s => s.SurveyUserRoles)
     .WithOne(sur => sur.Survey)
     .HasForeignKey(sur => sur.SurveyId);

            modelBuilder.Entity<Role>()
                .HasMany(r => r.SurveyUserRoles)
                .WithOne(sur => sur.Roles)
                .HasForeignKey(sur => sur.RoleId);

            // Define other relationships as needed...

            base.OnModelCreating(modelBuilder);
        }
    }
}