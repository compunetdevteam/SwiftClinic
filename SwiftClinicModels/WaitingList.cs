namespace SwiftClinicModels
{
    public class WaitingList
    {
        public int WaitingListId { get; set; }
        public int QueueId { get; set; }

        public int QueueDate { get; set; }
        public int ConsultationStatus { get; set; }
        public string PatientNumber { get; set; }

    }
}
