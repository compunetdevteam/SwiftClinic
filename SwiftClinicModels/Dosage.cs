using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwiftClinicModels
{
    public class Dosage
    {
        public int DosageId { get; set; }

        [Index(IsUnique = true)]
        [MaxLength(200)]
        public string DosageName { get; set; }
        public virtual ICollection<Pescription> Pescriptions { get; set; }
    }
}
