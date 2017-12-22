namespace SwiftClinicModels
{
    public class AssignSpecialization
    {
        public int AssignSpecializationId { get; set; }
        public int SpecializationId { get; set; }
        public string StaffNumber { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual Specialization Specialization { get; set; }
    }
}
