using System.Collections.Generic;

namespace SwiftClinicModels.Laboratory
{
    public class LabTest
    {
        public int LabTestId { get; set; }
        public int LabTestCategoryId { get; set; }
        public string LabTestName { get; set; }
        public decimal Price { get; set; }
        public virtual LabTestCategory LabTestCategory { get; set; }
        public virtual ICollection<LabTestRequest> LabTestRequests { get; set; }
    }
}
