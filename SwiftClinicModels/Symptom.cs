using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwiftClinicModels
{
    public class Symptom
    {
        public int SymptomId { get; set; }

        [Index(IsUnique = true)]
        [MaxLength(200)]
        public string SymptonName { get; set; }
        public virtual ICollection<PatientSymptom> PatientSymptoms { get; set; }
    }
}
