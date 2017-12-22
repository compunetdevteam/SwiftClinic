using BinghamWebApp.Models;
using System.Collections.Generic;

namespace SwiftClinicModels
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Staff> Staff { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
