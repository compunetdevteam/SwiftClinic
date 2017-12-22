namespace SwiftClinicModels.Billing
{
    public class BillType
    {
        public int BillTypeId { get; set; }
        public string PatientType { get; set; }
        public string BillName { get; set; }
        public string BillDescription { get; set; }
        public decimal Amount { get; set; }
        public string AmountInWord { get; set; }

    }
}
