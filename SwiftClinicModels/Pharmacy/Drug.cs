using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SwiftClinicModels.Pharmacy
{
    public class Drug
    {
        public int DrugCategoryId { get; set; }

        public int CategoryId { get; set; }

        [Required(ErrorMessage = "An Drug Name is required")]
        [StringLength(160)]
        public string Name { get; set; }

        [Display(Name = "Alternative/General Name")]
        [StringLength(200)]
        public string AlternativeName { get; set; }

        [Required(ErrorMessage = "Price Per Quantity")]
        public decimal Price { get; set; }

        [Range(1, 1000)]
        [DisplayName("Quantity")]
        [Required(ErrorMessage = "Quantity")]
        public int Quantity { get; set; }

        [DisplayName("Unit Name")]
        public string Unit { get; set; }

        [DisplayName("Other Unit Name")]
        public string OtherUnitName { get; set; }

        [Display(Name = "Product Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public decimal? ProductDiscount { get; set; }

        public decimal DiscountPrice
        {
            get
            {
                if (ProductDiscount != null)
                {
                    decimal calculatedPrice = ((decimal)ProductDiscount / 100) * Price;
                    decimal discountPrice = Price - calculatedPrice;
                    return Math.Round(discountPrice, 2);
                }
                return 0;
            }
            set { }
        }

        public bool IsApproved { get; set; }

        public DateTime DateAdded
        {

            get
            {
                return DateTime.Now;
            }
            set { }
        }
        public int? StockQuantity { get; set; }

        public virtual DrugCategory DrugCategory { get; set; }
    }
}
