using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwiftClinicModels
{
    public class Specialization
    {
        public int SpecializationId { get; set; }
        [Index(IsUnique = true)]
        [MaxLength(20)]
        public string SpecializationCode { get; set; }

        [Index(IsUnique = true)]
        [MaxLength(200)]
        public string SpecializationName { get; set; }
        public AssignSpecialization AssignSpecialization { get; set; }
    }
}
