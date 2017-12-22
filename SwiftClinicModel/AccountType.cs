using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwiftClinicModel;

namespace BinghamWebApp.Models
{ 
    public class AccountType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountTypeID { get; set; }

        [Required]
        [Display(Name = "Account Name")]
        public PopUp.AccountName AccountName { get; set; }

        [Key]
        [Range(0, 100000)]
        [Required]
        [Display(Name = "Account Number")]
        public int AccountNumber { get; set; }

        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }

        [Display(Name = "Registered By")]
        [Required]
        public string StaffNumber { get; set; }

        [Display(Name = "Patient ID")]
        [Required]
        [Range(0, 100000)]
        public int PatientNumber { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
