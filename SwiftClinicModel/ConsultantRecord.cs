using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinghamWebApp.Models
{
    public class ConsultantRecord
    {       
        public int ConsultantRecordID { get; set; }  

        public PopUp.Clinic Clinic { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "The Date is required")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name = "Examination")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Examination is required")]
        public string Examination { get; set; }

        [Display(Name = "Diagnosis")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Diagnosis is required")]
        public string Diagnosis { get; set; }

        [Display(Name = "Treatment")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Treatment is required")]
        public string Treatment { get; set; }

        [Display(Name = "Doctor in Charge")]
        [Required]
        public string StaffNumber { get; set; }

        public int PatientNumber { get; set; }
       
        public virtual Patient Patients { get; set; }

    }
}
