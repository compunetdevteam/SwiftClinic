using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SwiftClinicModels
{
    public class ConsultantRecord
    {
        public int ConsultantRecordId { get; set; }
        public int PatientNumber { get; set; }

        [Display(Name = "Doctor in Charge")]
        [Required]
        public string StaffNumber { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string ConsultantInfo { get; set; }

        public virtual Patient Patients { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual ICollection<Pescription> Pescriptions { get; set; }
        public virtual ICollection<PatientSymptom> PatientSymptoms { get; set; }
        public virtual ICollection<PatientDiagnosis> PatientDiagnoses { get; set; }
        public virtual ICollection<PatientDoDont> PatientDoDonts { get; set; }

    }
}
