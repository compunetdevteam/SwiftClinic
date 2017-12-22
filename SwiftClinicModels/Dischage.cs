using System;

namespace SwiftClinicModels
{
    public class Dischage
    {
        public int DischageId { get; set; }
        public string PatientNumber { get; set; }
        public string StaffNumber { get; set; }
        public string DischargeAdvice { get; set; }
        public string ConditionOnDisCharge { get; set; }
        public DateTime DischargeDate { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
