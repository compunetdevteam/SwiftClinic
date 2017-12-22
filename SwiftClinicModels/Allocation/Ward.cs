using System.Collections.Generic;

namespace SwiftClinicModels.Allocation
{
    public class Ward
    {
        public int WardId { get; set; }
        public int BuildingId { get; set; }
        public string WardCode { get; set; }
        public string WardName { get; set; }
        public virtual Building Building { get; set; }
        public ICollection<Room> Rooms { get; set; }
        public virtual ICollection<AssignBedSpace> AssignBedSpaces { get; set; }


    }
}
