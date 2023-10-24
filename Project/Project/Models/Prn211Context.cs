using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Project.Models;

public partial class Prn211Context : DbContext
{
    public Prn211Context()
    {
    }

    public Prn211Context(DbContextOptions<Prn211Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<ClassStudentSubject> ClassStudentSubjects { get; set; }

    public virtual DbSet<Score> Scores { get; set; }

    public virtual DbSet<ScoreSubjectStudent> ScoreSubjectStudents { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=MSI;database=prn211;user=sa;password=123;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.ClassId).HasName("PK__Class__7577347EE84C8696");

            entity.ToTable("Class");

            entity.Property(e => e.ClassId)
                .ValueGeneratedNever()
                .HasColumnName("classId");
            entity.Property(e => e.ClassName).HasColumnName("className");
        });

        modelBuilder.Entity<ClassStudentSubject>(entity =>
        {
            entity.HasKey(e => new { e.ClassId, e.StudentId, e.SubjectId }).HasName("PK__ClassStu__C00AD0BA3B5F5182");

            entity.ToTable("ClassStudentSubject");

            entity.Property(e => e.ClassId).HasColumnName("classId");
            entity.Property(e => e.StudentId).HasColumnName("studentId");
            entity.Property(e => e.SubjectId).HasColumnName("subjectId");

            entity.HasOne(d => d.Class).WithMany(p => p.ClassStudentSubjects)
                .HasForeignKey(d => d.ClassId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ClassStud__class__5070F446");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassStudentSubjects)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ClassStud__stude__5165187F");

            entity.HasOne(d => d.Subject).WithMany(p => p.ClassStudentSubjects)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ClassStud__subje__52593CB8");
        });

        modelBuilder.Entity<Score>(entity =>
        {
            entity.HasKey(e => e.ScoreId).HasName("PK__Score__B56A0C8D682462B8");

            entity.ToTable("Score");

            entity.Property(e => e.ScoreId)
                .ValueGeneratedNever()
                .HasColumnName("scoreId");
            entity.Property(e => e.Assignment).HasColumnName("assignment");
            entity.Property(e => e.Lab1).HasColumnName("lab1");
            entity.Property(e => e.Lab2).HasColumnName("lab2");
            entity.Property(e => e.PracticalExam).HasColumnName("practicalExam");
            entity.Property(e => e.TheoryExam).HasColumnName("theoryExam");
        });

        modelBuilder.Entity<ScoreSubjectStudent>(entity =>
        {
            entity.HasKey(e => e.SssId).HasName("PK__ScoreSub__61711C8FEE53E72D");

            entity.ToTable("ScoreSubjectStudent");

            entity.Property(e => e.SssId)
                .ValueGeneratedNever()
                .HasColumnName("sssId");
            entity.Property(e => e.ScoreId).HasColumnName("scoreId");
            entity.Property(e => e.StudentId).HasColumnName("studentId");
            entity.Property(e => e.SubjectId).HasColumnName("subjectId");

            entity.HasOne(d => d.Score).WithMany(p => p.ScoreSubjectStudents)
                .HasForeignKey(d => d.ScoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ScoreSubj__score__6FE99F9F");

            entity.HasOne(d => d.Student).WithMany(p => p.ScoreSubjectStudents)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ScoreSubj__stude__70DDC3D8");

            entity.HasOne(d => d.Subject).WithMany(p => p.ScoreSubjectStudents)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ScoreSubj__subje__71D1E811");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Student__4D11D63CCA898CFA");

            entity.ToTable("Student");

            entity.Property(e => e.StudentId)
                .ValueGeneratedNever()
                .HasColumnName("studentId");
            entity.Property(e => e.StudentName).HasColumnName("studentName");

            entity.HasMany(d => d.Subjects).WithMany(p => p.Students)
                .UsingEntity<Dictionary<string, object>>(
                    "StudentSubject",
                    r => r.HasOne<Subject>().WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__StudentSu__subje__38996AB5"),
                    l => l.HasOne<Student>().WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__StudentSu__stude__37A5467C"),
                    j =>
                    {
                        j.HasKey("StudentId", "SubjectId").HasName("PK__StudentS__57DE4C4A73B32A4E");
                        j.ToTable("StudentSubject");
                        j.IndexerProperty<int>("StudentId").HasColumnName("studentId");
                        j.IndexerProperty<int>("SubjectId").HasColumnName("subjectId");
                    });
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.SubjectId).HasName("PK__Subject__ACF9A7606777F4F2");

            entity.ToTable("Subject");

            entity.Property(e => e.SubjectId)
                .ValueGeneratedNever()
                .HasColumnName("subjectId");
            entity.Property(e => e.SubjectName).HasColumnName("subjectName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
