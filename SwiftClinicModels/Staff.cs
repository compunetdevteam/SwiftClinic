using BinghamWebApp.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwiftClinicModels
{
    public class Staff : Person
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StaffId { get; set; }

        [Key]
        public int StaffNumber { get; set; }

        public string Specialization { get; set; }

        public string StaffRole { get; set; }

        public virtual ICollection<ConsultantRecord> ConsultantRecords { get; set; }
    }
}
