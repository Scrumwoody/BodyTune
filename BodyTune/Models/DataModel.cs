using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BodyTune.Models
{
    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModel")
        {
        }

        public virtual DbSet<Assignment> Assignments { get; set; }
        public virtual DbSet<BodyPart> BodyParts { get; set; }
        public virtual DbSet<Exercise> Exercises { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BodyPart>()
                .Property(e => e.BodyPartName)
                .IsUnicode(false);

            modelBuilder.Entity<BodyPart>()
                .HasMany(e => e.Exercises)
                .WithRequired(e => e.BodyPart)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Exercise>()
                .Property(e => e.ExerciseName)
                .IsUnicode(false);

            modelBuilder.Entity<Exercise>()
                .Property(e => e.ExerciseDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Exercise>()
                .Property(e => e.ExerciseImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Exercise>()
                .HasMany(e => e.Assignments)
                .WithRequired(e => e.Exercise)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.RoleType)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.NameOfMyTherapist)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.AddressLine1)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.AddressLine2)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Zip)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Assignments)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}