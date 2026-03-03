namespace AiOi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Patients
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patients()
        {
            Visits = new HashSet<Visits>();
        }

        [Key]
        public int IdPatient { get; set; }

        [Required]
        [StringLength(200)]
        public string FullName { get; set; }

        [StringLength(100)]
        public string UserName { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        public int? UserRoleId { get; set; }

        public int GenderId { get; set; }

        [Column(TypeName = "date")]
        public DateTime BirthdayDate { get; set; }

        [Required]
        [StringLength(100)]
        public string InsurancePolicy { get; set; }

        [Column(TypeName = "date")]
        public DateTime FluorographyDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ClinicalExaminationDate { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        public int? DisabilityGroup1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DisabilityGroup1Date { get; set; }

        public int? DisabilityGroup2 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DisabilityGroup2Date { get; set; }

        public int? DisabilityGroup3 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DisabilityGroup3Date { get; set; }

        [StringLength(100)]
        public string ImagePatch { get; set; }

        public virtual Gender Gender { get; set; }

        public virtual UserRole UserRole { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visits> Visits { get; set; }
    }
}
