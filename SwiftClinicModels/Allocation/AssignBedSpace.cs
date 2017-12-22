using System;
using System.ComponentModel.DataAnnotations;

namespace SwiftClinicModels.Allocation
{
    public class AssignBedSpace
    {
        public int AssignBedSpaceId { get; set; }
        [Display(Name = "Patient Name")]
        public string PatientNumber { get; set; }
        public int? BuildingId { get; set; }
        public int? WardId { get; set; }
        public int RoomId { get; set; }
        public string BedSpace { get; set; }
        public bool PaymentStatus { get; set; }
        public DateTime AssignedDate { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Building Building { get; set; }
        public virtual Ward Ward { get; set; }
        public virtual Room Room { get; set; }

    }
}
