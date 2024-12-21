using MD4_SQL.Factories;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace MD4_SQL.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        // Create tables
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Submission> Submissions { get; set; }

        // Create relationships
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Asked Copilot how to define FK constraints
            // One-to-many relationship between Teacher and Course
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Teacher)
                .WithMany()
                .HasForeignKey(c => c.TeacherId)
                .OnDelete(DeleteBehavior.Cascade);

            // One-to-many relationship between Course and Assignment
            modelBuilder.Entity<Assignment>()
                .HasOne(a => a.Course)
                .WithMany()
                .HasForeignKey(a => a.CourseId)
                .OnDelete(DeleteBehavior.Cascade);

            // One-to-many relationship between Assignment and Submission
            modelBuilder.Entity<Submission>()
                .HasOne(s => s.Assignment)
                .WithMany()
                .HasForeignKey(s => s.AssignmentId)
                .OnDelete(DeleteBehavior.Cascade);

            // One-to-many relationship between Student and Submission
            modelBuilder.Entity<Submission>()
                .HasOne(s => s.Student)
                .WithMany()
                .HasForeignKey(s => s.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            // Seed data using factories
            var teachers = TeacherFactory.CreateMany(10);
            modelBuilder.Entity<Teacher>().HasData(teachers);

            var ids = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var courses = CourseFactory.CreateMany(10, ids);
            modelBuilder.Entity<Course>().HasData(courses);

            var students = StudentFactory.CreateMany(10);
            modelBuilder.Entity<Student>().HasData(students);

            var assignments = AssignmentFactory.CreateMany(10, ids);
            modelBuilder.Entity<Assignment>().HasData(assignments);

            var submissions = SubmissionFactory.CreateMany(10, ids, ids);
            modelBuilder.Entity<Submission>().HasData(submissions);

        }
        // some warning that can't find a reason for
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }

    }
}
