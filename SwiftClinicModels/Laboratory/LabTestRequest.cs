namespace SwiftClinicModels.Laboratory
{
    public class LabTestRequest
    {
        public int LabTestRequestId { get; set; }
        public string PatientNumber { get; set; }
        public string StaffNumber { get; set; }
        public int LabTestId { get; set; }
        public virtual LabTest LabTest { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual LabReport LabReport { get; set; }

    }
}
