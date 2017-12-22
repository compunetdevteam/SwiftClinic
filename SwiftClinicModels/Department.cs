using BinghamWebApp.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwiftClinicModels
{
    public class Department
    {
        public int DepartmentId { get; set; }
        [Index(IsUnique = true)]
        [MaxLength(200)]
        public string DepartmentCode { get; set; }
        [Index(IsUnique = true)]
        [MaxLength(200)]
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Staff> Staff { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
