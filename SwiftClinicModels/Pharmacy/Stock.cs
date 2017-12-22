using System;
using System.ComponentModel.DataAnnotations;

namespace SwiftClinicModels.Pharmacy
{
    public class Stock
    {
        public int StockId { get; set; }

        [Display(Name = "Product Name")]
        public String DrugId { get; set; }

        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Display(Name = "Date Of Creation")]
        [Required(ErrorMessage = "The Date is required")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public PopUp.StockStatus Status { get; set; }

        [Display(Name = "Staff Name")]
        public string StaffNumber { get; set; }

        public virtual Staff Staff { get; set; }

    }
}