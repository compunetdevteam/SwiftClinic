using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using SwiftClinicModel;

namespace BinghamWebApp.Models
{ 
    public class PreliminaryExamination
    {
        public int ID { get; set; }

        [Display(Name = "Clinic Name")]
        [Required(ErrorMessage = "Your Clinic name is required")]        
        public PopUp.Clinic Clinic { get; set; }

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
        [Range(0, 100000)]
        public int PatientNumber { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual Staff Staff { get; set; }

    }
}
