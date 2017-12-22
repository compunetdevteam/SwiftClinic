using System.Collections.Generic;

namespace SwiftClinicModels.Allocation
{
    public class Building
    {
        public int BuildingId { get; set; }
        public string BuildingCode { get; set; }
        public string BuildingName { get; set; }
        public virtual ICollection<Ward> Wards { get; set; }
        public virtual ICollection<AssignBedSpace> AssignBedSpaces { get; set; }

    }
}
