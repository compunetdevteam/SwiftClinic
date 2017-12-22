using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwiftClinicModel;
using SwiftClinicModels;

namespace BinghamWebApp.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }

        [Display(Name = "Subject")]
        [Required(ErrorMessage = "The Subject is required")]
        [StringLength(40, ErrorMessage = "The Subject is too long")]
        public string Subject { get; set; }

        [Display(Name = "Date Visited")]
        [Required(ErrorMessage = "The Date is required")]
        [DataType(DataType.Date)]
        public DateTime DateVisited { get; set; }

        [Display(Name = "Appointment Date")]
        [Required(ErrorMessage = "The Date is required")]
        [DataType(DataType.Date)]
        public DateTime AppointmentTime { get; set; }

        [Display(Name = "Doctor in Charge")]
        [Required]
        [Range(0, 1000)]
        public string StaffNumber { get; set; }

        [Display(Name = "Details")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Details is required")]
        [StringLength(200, ErrorMessage = "Your Details name is too long")]
        public string Detail { get; set; }

        [Display(Name = "Clinic Name")]
        [Required(ErrorMessage = "Your Clinic name is required")]
        public PopUp.Clinic Clinic { get; set; }

        [Required]
        [Range(0, 100000)]
        public int PatientNumber { get; set; }

        public virtual Patient Patient { get; set; }
        public virtual Staff Staff { get; set; }

    }
}
