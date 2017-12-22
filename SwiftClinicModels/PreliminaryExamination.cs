using System;
using System.ComponentModel.DataAnnotations;

namespace SwiftClinicModels
{
    public class PreliminaryExamination
    {
        public int PreliminaryExaminationId { get; set; }

        [Display(Name = "Clinic Name")]
        [Required(ErrorMessage = "Your Clinic name is required")]
        public int DepartmentId { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "The Date is required")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name = "Blood Pressure B/P")]
        [Required(ErrorMessage = "The Blood Pressure is required")]
        [StringLength(40, ErrorMessage = "Your First name is too long")]
        public string BloodPressure { get; set; }

        [Display(Name = "Weight")]
        [Required(ErrorMessage = "the Weight is required")]
        [Range(typeof(decimal), "0.00", "150.00")]
        public decimal Weight { get; set; }

        [Display(Name = "Nurse in Charge")]
        [Required]
        public string StaffNumber { get; set; }

        [Display(Name = "Patient ID")]
        [Required]
        public string PatientNumber { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual Staff Staff { get; set; }
        public virtual Department Department { get; set; }

    }
}
