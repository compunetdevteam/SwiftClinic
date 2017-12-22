using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwiftClinicModels
{
    public class Diagnosis
    {
        public int DiagnosisId { get; set; }

        [Index(IsUnique = true)]
        [MaxLength(200)]
        public string DiagnosisName { get; set; }
    }
}
