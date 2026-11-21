
using Microsoft.EntityFrameworkCore;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    public DbSet<Faculty> Faculties => Set<Faculty>();
    public DbSet<Department> Departments => Set<Department>();
    public DbSet<Teacher> Teachers => Set<Teacher>();
    public DbSet<Discipline> Disciplines => Set<Discipline>();
    public DbSet<Student> Students => Set<Student>();
    public DbSet<TeachingAssignment> TeachingAssignments => Set<TeachingAssignment>();
    public DbSet<TeachingAssignmentDiscipline> TeachingAssignmentDisciplines
        => Set<TeachingAssignmentDiscipline>();
    public DbSet<AcademicPerformance> AcademicPerformances
        => Set<AcademicPerformance>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Faculty>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).IsRequired();
            entity.Property(x => x.DeanFullName).IsRequired();
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).IsRequired();
            entity.Property(x => x.HeadFullName).IsRequired();

            entity.HasOne<Faculty>()
                .WithMany()
                .HasForeignKey(x => x.FacultyId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.FirstName).IsRequired();
            entity.Property(x => x.LastName).IsRequired();
            entity.Property(x => x.MiddleName).IsRequired();
            entity.Property(x => x.AcademicDegree).IsRequired();
            entity.Property(x => x.Position).HasConversion<int>();
        });

        modelBuilder.Entity<Discipline>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).IsRequired();
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.FirstName).IsRequired();
            entity.Property(x => x.LastName).IsRequired();
            entity.Property(x => x.MiddleName).IsRequired();
            entity.Property(x => x.StudentNumber).IsRequired();
            entity.Property(x => x.StreamName).IsRequired();
            entity.Property(x => x.GroupName).IsRequired();
            entity.Property(x => x.BirthDate).HasColumnType("date");

            entity.HasOne<Department>()
                .WithMany()
                .HasForeignKey(x => x.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<TeachingAssignment>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.AssignmentDate)
                .HasColumnType("timestamp without time zone");

            entity.HasOne<Teacher>()
                .WithMany()
                .HasForeignKey(x => x.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne<Department>()
                .WithMany()
                .HasForeignKey(x => x.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<TeachingAssignmentDiscipline>(entity =>
        {
            entity.HasKey(x => x.Id);

            entity.HasOne<TeachingAssignment>()
                .WithMany()
                .HasForeignKey(x => x.TeachingAssignmentId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne<Discipline>()
                .WithMany()
                .HasForeignKey(x => x.DisciplineId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<AcademicPerformance>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.AcademicYear).IsRequired();
            entity.Property(x => x.Options).HasConversion<int>();
            entity.Property(x => x.AssessmentDate)
                .HasColumnType("timestamp without time zone");

            entity.HasOne<Student>()
                .WithMany()
                .HasForeignKey(x => x.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne<TeachingAssignmentDiscipline>()
                .WithMany()
                .HasForeignKey(x => x.TeachingAssignmentDisciplineId)
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
}
