namespace AiOi.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class MedicalSpecialists
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MedicalSpecialists()
        {
            Visits = new HashSet<Visits>();
        }

        [Key]
        public int IdMedicalSpecialist { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visits> Visits { get; set; }
    }
}
