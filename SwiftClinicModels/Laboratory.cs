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
    public class Laboratory
    {
       
        public int LaboratoryID { get; set; }

        [Display(Name = "Clinic Name")]
        [Required(ErrorMessage = "Your Clinic name is required")]
        public PopUp.Clinic Clinic { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "The Date is required")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name = "Required Investigation")]
        [Required(ErrorMessage = "The Blood Pressure is required")]
        [StringLength(100, ErrorMessage = "Required Investigationt name is too long")]
        public string RequiredInvestigation { get; set; }

        [Display(Name = "Laboratory Result")]
        [Required(ErrorMessage = "the Result is required")]      
        public string LabResult { get; set; }

        [Display(Name = "Laboratory Remark")]
        [Required(ErrorMessage = "the Result is required")]
        public string LabRemark { get; set; }

        [Display(Name = "Officer in Charge")]
        [Required]
        public string StaffNumber { get; set; }

        [Display(Name = "Reporting Date")]
        [Required(ErrorMessage = "The Date is required")]
        [DataType(DataType.Date)]
        public DateTime ReportDate { get; set; }

        [Display(Name = "Patient ID")]
        [Required]
        [Range(0, 100000)]
        public int PatientNumber { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual Staff Staff { get; set; }

    }
}
