namespace SwiftClinicModels
{
    public class PatientDoDont
    {
        public int PatientDoDontId { get; set; }
        public int ConsultantRecordId { get; set; }
        public string Note { get; set; }
        public bool IsDoable { get; set; }
        public virtual ConsultantRecord ConsultantRecord { get; set; }

    }
}
