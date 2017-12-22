using BinghamWebApp.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwiftClinicModel
{
    public class Staff
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StaffId { get; set; }

        [Key]
        public int StaffNumber { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string Name
        {
            get
            {
                return string.Format("{0} {1}", this.FirstName, this.LastName);
            }
        }

        public PopUp.Clinic Clinic { get; set; }



        public string Specialization { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string ApplicationUserID { get; set; }


        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<ConsultantRecord> ConsultantRecords { get; set; }
    }
}
