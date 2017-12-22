using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SwiftClinicModels.Allocation
{
    public class Room
    {
        public int RoomId { get; set; }

        [Display(Name = "Ward Name")]
        [Required(ErrorMessage = "Your Ward Name is required")]
        public int WardId { get; set; }

        [Display(Name = "Room")]
        [Required(ErrorMessage = "Your Room is required")]
        public string RoomName { get; set; }

        public decimal RoomPrice { get; set; }

        [Display(Name = "Available Number of Bed Space")]
        [Required(ErrorMessage = "Your Room Bed Space Capacity is required")]
        public int BedSpace { get; set; }
        public virtual Ward Ward { get; set; }
        public virtual ICollection<AssignBedSpace> AssignBedSpaces { get; set; }

    }
}
