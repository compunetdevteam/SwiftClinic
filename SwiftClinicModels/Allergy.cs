using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwiftClinicModels
{
    public class Allergy
    {
        public int AllergyId { get; set; }
        [Index(IsUnique = true)]
        [MaxLength(200)]
        public string AllergyName { get; set; }
        public virtual ICollection<PatientAllergy> PatientAllergies { get; set; }
    }
}
