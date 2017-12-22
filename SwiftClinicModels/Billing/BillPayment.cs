using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwiftClinicModels.Billing
{
    public class BillPayment
    {
        public int BillPaymentId { get; set; }
        public string PatientNumber { get; set; }
        [Index(IsUnique = true)]
        [MaxLength(50)]
        [Required] 
        public string OrderId { get; set; }
        public string ReferenceId { get; set; }

        [Display(Name = "Total Amount")]
        public decimal TotalAmount { get; set; }

        [Display(Name = "Paid Amount")]
        public decimal PaidAmount { get; set; }

        [Display(Name = "Payment Method")]
        public PopUp.PMode PaymentMode { get; set; }

        [Display(Name = "Fee Status")]
        public bool Status { get; set; }

        public bool IsPartPayment
        {
            get
            {
                if (Math.Round(PaidAmount, 2) < Math.Round(TotalAmount, 2))
                {
                    return true;
                }
                return false;
            }
            set { }
        }

        public bool IsFullPayment
        {
            get
            {
                if (Math.Round(PaidAmount, 2) == Math.Round(TotalAmount, 2))
                {
                    return true;
                }
                return false;
            }
            set { }
        }
        public string PaymentStatus { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
