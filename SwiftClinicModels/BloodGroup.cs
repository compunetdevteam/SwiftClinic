using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwiftClinicModels
{
    public class BloodGroup
    {
        public int BloodGroupId { get; set; }

        [Index(IsUnique = true)]
        [MaxLength(20)]
        public string BloodGroupName { get; set; }
    }
}
