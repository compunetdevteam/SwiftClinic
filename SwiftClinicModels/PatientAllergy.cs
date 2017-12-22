namespace SwiftClinicModels
{
    public class PatientAllergy
    {
        public int PatientAllergyId { get; set; }
        public int AllergyId { get; set; }
        public int? DrugId { get; set; }
        public string PatientNumber { get; set; }
        public virtual Allergy Allergy { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
