using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AiOi.Models
{
    public partial class AiOiModel : DbContext
    {
        public AiOiModel()
            : base("name=AiOiModel")
        {
        }

        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<MedicalSpecialists> MedicalSpecialists { get; set; }
        public virtual DbSet<Patients> Patients { get; set; }
        public virtual DbSet<Visits> Visits { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gender>()
                .HasMany(e => e.Patients)
                .WithRequired(e => e.Gender)
                .HasForeignKey(e => e.GenderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MedicalSpecialists>()
                .HasMany(e => e.Visits)
                .WithRequired(e => e.MedicalSpecialists)
                .HasForeignKey(e => e.MedicalSpecialistId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patients>()
                .HasMany(e => e.Visits)
                .WithRequired(e => e.Patients)
                .HasForeignKey(e => e.PatientId)
                .WillCascadeOnDelete(false);
        }
    }
}
