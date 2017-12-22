namespace SwiftClinicModels
{
    public class PatientDiagnosis
    {
        public int PatientDiagnosisId { get; set; }
        public int ConsultantRecordId { get; set; }
        public int DiagnosisId { get; set; }
        public string DiagnosisType { get; set; }
        public virtual Diagnosis Diagnosis { get; set; }
        public virtual ConsultantRecord ConsultantRecord { get; set; }
    }
}
