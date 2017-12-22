namespace SwiftClinicModels
{
    public class PatientSymptom
    {
        public int PatientSymptomId { get; set; }
        public int ConsultantRecordId { get; set; }
        public int SymptomId { get; set; }
        public virtual ConsultantRecord ConsultantRecord { get; set; }
        public virtual Symptom Symptom { get; set; }

    }
}
