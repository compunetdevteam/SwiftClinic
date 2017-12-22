using System;

namespace SwiftClinicModels.BloodBank
{
    public class DonationHistory
    {
        public int DonationHistoryId { get; set; }
        public int BloodDonorId { get; set; }
        public int BloodGroupId { get; set; }
        public double PintDonated { get; set; }
        public DateTime DonationDate { get; set; }
        public virtual BloodDonor BloodDonor { get; set; }
        public virtual BloodGroup BloodGroup { get; set; }
    }
}
