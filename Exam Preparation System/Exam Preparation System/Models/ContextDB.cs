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
        public virtual DbSet<CADIDATELIST> CADIDATELISTs { get; set; }
        public virtual DbSet<EXAMINATION> EXAMINATIONS { get; set; }
        public virtual DbSet<EXAMQUESTION> EXAMQUESTIONS { get; set; }
        public virtual DbSet<EXAMRESULT> EXAMRESULTS { get; set; }
        public virtual DbSet<QUESTION> QUESTIONS { get; set; }
        public virtual DbSet<REPORT> REPORTS { get; set; }
        public virtual DbSet<SUBJECT> SUBJECTS { get; set; }
        public virtual DbSet<USER> USERS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ANSWER>()
                .Property(e => e.AnswersContent)
                .IsUnicode(false);

            modelBuilder.Entity<CADIDATELIST>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<EXAMINATION>()
                .Property(e => e.PINCode)
                .IsUnicode(false);

            modelBuilder.Entity<EXAMINATION>()
                .HasMany(e => e.CADIDATELISTs)
                .WithRequired(e => e.EXAMINATION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EXAMQUESTION>()
                .HasMany(e => e.EXAMRESULTS)
                .WithRequired(e => e.EXAMQUESTION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EXAMRESULT>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<QUESTION>()
                .Property(e => e.Contents)
                .IsUnicode(false);


            modelBuilder.Entity<REPORT>()
                .Property(e => e.Contents)
                .IsUnicode(false);

            modelBuilder.Entity<SUBJECT>()
                .Property(e => e.SubName)
                .IsUnicode(false);

            modelBuilder.Entity<SUBJECT>()
                .Property(e => e.Descriptions)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .HasMany(e => e.CADIDATELISTs)
                .WithRequired(e => e.USER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USER>()
                .HasMany(e => e.EXAMRESULTS)
                .WithRequired(e => e.USER)
                .WillCascadeOnDelete(false);
        }
    }
}
