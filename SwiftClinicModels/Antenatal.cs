using System;

namespace SwiftClinicModels
{
    public class Antenatal
    {
        public int AntenatalId { get; set; }
        public string PatientNumber { get; set; }
        public DateTime RegisteredDate { get; set; }

        public bool HasDelivered { get; set; }
        public bool IsSuccessful { get; set; }
        public bool IsCesereanSection { get; set; }
        public string Survival { get; set; }
        public string SurvivalRate { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
