using System.Collections.Generic;

namespace SwiftClinicModels.Laboratory
{
    public class LabTestCategory
    {
        public int LabTestCategoryId { get; set; }
        public string LabTestCode { get; set; }
        public string LabTestName { get; set; }
        public virtual ICollection<LabTest> LabTests { get; set; }
    }
}
