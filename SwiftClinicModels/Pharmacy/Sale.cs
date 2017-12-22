using System;
using System.Collections.Generic;

namespace SwiftClinicModels.Pharmacy
{
    public partial class Sale
    {
        public int SaleId { get; set; }
        public DateTime SaleDate { get; set; }
        public string PatientNumber { get; set; }
        public string ReferenceNo { get; set; }
        public string ROrderId { get; set; }
        public decimal Total { get; set; }
        public bool IsPayed { get; set; }
        public bool IsDelivered { get; set; }
        public List<SaleDetail> SaleDetails { get; set; }
        public virtual Patient Patient { get; set; }


    }
}