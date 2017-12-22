using System;
using System.ComponentModel.DataAnnotations;

namespace SwiftClinicModels
{
    public class Emergency
    {
        public int EmergencyId { get; set; }
      
        public string MaritalStatus { get; set; }
        public string Injury { get; set; }
        public string Detail { get; set; }
        public string Treatment { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string BroughtBy { get; set; }
        public string BBPhoneNumber { get; set; }
        public string BBRelationship { get; set; }

        [Required]
        public int PatientID { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
