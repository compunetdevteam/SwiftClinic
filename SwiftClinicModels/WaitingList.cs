using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwiftClinicModels;

namespace BinghamWebApp.Models
{
    public class WaitingList
    {
        public int WaitingListID { get; set; }
        public int QueueID { get; set; }
       
        public int Specialist { get; set; }
        public int QueueDate { get; set; }
        public int ConsultationStatus { get; set; }
        [Required]
        public int PatientID { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
