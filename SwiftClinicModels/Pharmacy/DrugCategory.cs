using System.Collections.Generic;

namespace SwiftClinicModels.Pharmacy
{
    public class DrugCategory
    {
        public int DrugCategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Drug> Drugs { get; set; }
    }
}
