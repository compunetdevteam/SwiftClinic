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
        public string StaffNumber { get; set; }

        public string Specialization { get; set; }

        public string StaffRole { get; set; }

        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<ConsultantRecord> ConsultantRecords { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<AssignSpecialization> AssignSpecialization { get; set; }
        public virtual ICollection<StaffAcademicHistory> StaffAcademicHistories { get; set; }
        public virtual ICollection<Dischage> Dischages { get; set; }
        public virtual ICollection<PreliminaryExamination> PreliminaryExaminations { get; set; }
    }
}
