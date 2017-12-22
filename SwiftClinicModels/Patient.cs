using BinghamWebApp.Models;
using SwiftClinicModels.Allocation;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwiftClinicModels
{

    public class Patient : Person
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatientId { get; set; }

        [Display(Name = "Hospital Number")]
        [Key]
        public string PatientNumber { get; set; }


        [Display(Name = "Tribe")]
        [Required(ErrorMessage = "Your Tribe is required")]
        public string Tribe { get; set; }

        public string PatientType { get; set; }

        public bool IsDead { get; set; }

        [Display(Name = "Registered By")]
        public virtual Staff Staff { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<ConsultantRecord> ConsultantRecords { get; set; }
        public virtual ICollection<HealthScheme> HealthSchemes { get; set; }
        public virtual ICollection<Pescription> Pescriptions { get; set; }
        public virtual ICollection<AssignBedSpace> AssignBedSpaces { get; set; }
        public virtual ICollection<PatientAllergy> PatientAllergies { get; set; }
        public virtual ICollection<Dischage> Dischages { get; set; }
        public virtual ICollection<Antenatal> Antenatals { get; set; }
        public virtual ICollection<PreliminaryExamination> PreliminaryExaminations { get; set; }



    }
}
