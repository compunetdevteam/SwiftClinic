using SwiftClinicModels;
using System;
using System.ComponentModel.DataAnnotations;

namespace BinghamWebApp.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }

        [Display(Name = "Subject")]
        [Required(ErrorMessage = "The Subject is required")]
        public string Subject { get; set; }

        [Display(Name = "Date Visited")]
        [DataType(DataType.Date)]
        public DateTime? DateVisited { get; set; }

        [Display(Name = "Appointment Date")]
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }

        [Display(Name = "Doctor in Charge")]
       // [Required]
        public string StaffNumber { get; set; }

        [Display(Name = "Details")]
        [DataType(DataType.MultilineText)]
        [StringLength(200, ErrorMessage = "Your Details name is too long")]
        public string Detail { get; set; }

        [Display(Name = "Clinic Name")]
        [Required(ErrorMessage = "Your Clinic name is required")]
        public int DepartmentId { get; set; }

        [Required]
        public string PatientNumber { get; set; }

        public bool IsCancelled { get; set; }
        public bool IsAttendedTo { get; set; }

        public virtual Patient Patient { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual Department Department { get; set; }

    }
}
