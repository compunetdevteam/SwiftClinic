using System;
using System.ComponentModel.DataAnnotations;

namespace SwiftClinicModels
{
    public class HealthScheme
    {
        public int HealthSchemeId { get; set; }

        [Required]
        [Display(Name = "Scheme Name")]
        public PopUp.SchemeName SchemeName { get; set; }

        [Required]
        [Display(Name = "Account Number")]
        public string AccountNumber { get; set; }

        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }

        [Display(Name = "Registered By")]
        //[Required]
        public string StaffNumber { get; set; }

        [Display(Name = "Patient ID")]
        [Required]
        [Range(0, 100000)]
        public string PatientNumber { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
