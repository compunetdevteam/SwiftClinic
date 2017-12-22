using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwiftClinicModels;

namespace BinghamWebApp.Models
{
    public class Admission
    {
        public int AdmissionID { get; set; }
        

        public string Clinic { get; set; }

        public string Ward { get; set; }
        public string BedNumber { get; set; }
        public string AdmissionDetails { get; set; }
        public string Specialist { get; set; }
        public DateTime DateAdmmited { get; set; }

        [Required]
        public int PatientID { get; set; }

        public virtual Patient Patient { get; set; }


    }
}
