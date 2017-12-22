using System;

namespace SwiftClinicModels.BloodBank
{
    public class BloodRequest
    {
        public int BloodRequestId { get; set; }
        public int PatientNumber { get; set; }
        public int BloodGroupId { get; set; }
        public double PintRequested { get; set; }
        public DateTime RequestDate { get; set; }
        public bool IsApproved { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual BloodGroup BloodGroup { get; set; }
    }
}
