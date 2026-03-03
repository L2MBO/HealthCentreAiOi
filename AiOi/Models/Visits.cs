namespace AiOi.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Visits
    {
        [Key]
        public int IdVisit { get; set; }

        [Column(TypeName = "date")]
        public DateTime VisitDate { get; set; }

        public int PatientId { get; set; }

        public int MedicalSpecialistId { get; set; }

        public virtual MedicalSpecialists MedicalSpecialists { get; set; }

        public virtual Patients Patients { get; set; }
    }
}
