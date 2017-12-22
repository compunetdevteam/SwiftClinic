using System;

namespace SwiftClinicModels.BloodBank
{
    public class BloodDonor : Person2
    {
        public int BloodDonorId { get; set; }
        public int BloodGroupId { get; set; }
       
        public virtual BloodGroup BloodGroup { get; set; }

    }
}
