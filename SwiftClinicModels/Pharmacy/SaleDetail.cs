namespace SwiftClinicModels.Pharmacy
{
    public class SaleDetail
    {
        public int SaleDetailId { get; set; }
        public int SaleId { get; set; }
        public int DrugId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual Drug Drug { get; set; }
        public virtual Sale Sale { get; set; }
    }
}
