using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Exam_Preparation_System.Models
{
    public partial class ContextDB : DbContext
    {
        public ContextDB()
            : base("name=ContextDB")
        {
        }

        public virtual DbSet<ANSWER> ANSWERS { get; set; }
        public virtual DbSet<EXAMQUESTION> EXAMQUESTIONS { get; set; }
        public virtual DbSet<EXAMRESULT> EXAMRESULTS { get; set; }
        public virtual DbSet<LISTQUESTION> LISTQUESTIONs { get; set; }
        public virtual DbSet<QUESTION> QUESTIONS { get; set; }
        public virtual DbSet<SUBJECT> SUBJECTS { get; set; }
        public virtual DbSet<USER> USERS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EXAMQUESTION>()
                .Property(e => e.ExecutionTime)
                .IsUnicode(false);

            modelBuilder.Entity<EXAMQUESTION>()
                .HasMany(e => e.EXAMRESULTS)
                .WithRequired(e => e.EXAMQUESTION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EXAMQUESTION>()
                .HasMany(e => e.LISTQUESTIONs)
                .WithRequired(e => e.EXAMQUESTION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EXAMRESULT>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<QUESTION>()
                .HasMany(e => e.LISTQUESTIONs)
                .WithRequired(e => e.QUESTION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .HasMany(e => e.EXAMRESULTS)
                .WithRequired(e => e.USER)
                .WillCascadeOnDelete(false);
        }
    }
}
