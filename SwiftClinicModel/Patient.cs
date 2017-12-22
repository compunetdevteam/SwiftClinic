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
    
    public class Patient
    {       
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatientID { get; set; }

        [Display(Name = "Hospital Number")]
        [Key]
        [Range(0, 100000)]
        public int PatientNumber { get; set; }

        public PopUp.Salutation Salutation { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Your First name is required")]
        [StringLength(40, ErrorMessage = "Your First name is too long")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        [Required(ErrorMessage = "Your Middle name is required")]
        [StringLength(40, ErrorMessage = "Your Middle name is too long")]
        public string MiddleName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Your last name is required")]
        [StringLength(40, ErrorMessage = "Your last name is too long")]
        public string LastName { get; set; }

        [Display(Name = "Mobile Number")]
        [Required(ErrorMessage = "Enter the Correct Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Your Address is required")]
        [StringLength(50, ErrorMessage = "Your Address name is too long")]
        public string Address { get; set; }   

        [Display(Name = "Date of Birth")]
        [Required(ErrorMessage = "The Date is required")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name = "Religion")]
        [Required(ErrorMessage = "Your Religion is required")]        
        public PopUp.Religion Religion { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Your Gender is required")]       
        public PopUp.Gender Gender { get; set; }

        [Display(Name = "Marital Status")]
        [Required(ErrorMessage = "Your Marital Status is required")]
        public PopUp.Marital Marital_status { get; set; }

        [Display(Name = "State of Origin")]
        [Required(ErrorMessage = "Your State of Origin is required")]
        public PopUp.State State { get; set; }

        [Display(Name = "Local Government Area")]
        [Required(ErrorMessage = "YourLocal Government Area is required")]
        public string Lga { get; set; }

        [Display(Name = "Tribe")]
        [Required(ErrorMessage = "Your Tribe is required")]
        public string Tribe { get; set; }

        [Display(Name = "Next of kin's First Name")]
        [Required(ErrorMessage = "Your Next of kin's First Name is required")]
        [StringLength(40, ErrorMessage = "Your Next of kin's First name is too long")]
        public string NOK_FirstName { get; set; }

        [Display(Name = "Next of kin's Middle Name")]
        [Required(ErrorMessage = "Your Next of kin's Middle name is required")]
        [StringLength(40, ErrorMessage = "Your Next of kin's Middle name is too long")]
        public string NOK_MiddleName { get; set; }

        [Display(Name = "Next of kin's Last Name")]
        [Required(ErrorMessage = "Your Next of kin's last name is required")]
        [StringLength(40, ErrorMessage = "Your Next of kin's last name is too long")]
        public string NOK_LastName { get; set; }

        [Display(Name = "Next of kin's Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        public string NOK_PhoneNumber { get; set; }

        [Display(Name = "Next of kin's Address")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Your Next of kin's Address is required")]
        [StringLength(50, ErrorMessage = "Your Next of kin's Address name is too long")]
        public string NOK_Address { get; set; }

        [Display(Name = "Next of kin's Relationship")]
        [Required(ErrorMessage = "Your Next of kin's Relationship is required")]        
        public PopUp.Relationship NOK_Relationship { get; set; }

        [Display(Name = "Clinic Name")]
        [Required(ErrorMessage = "Your Clinic name is required")]     
        public PopUp.Clinic Clinic { get; set; }


        [Display(Name = "Registration Date")]
        [Required(ErrorMessage = "The Registration Date is required")]
        [DataType(DataType.Date)]
        public string RegDate { get; set; }

        [Display(Name = "Registered By")]
        [Required]
        public string StaffNumber { get; set; }

        public virtual Staff Staff { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<ConsultantRecord> ConsultantRecords { get; set; }
        public virtual ICollection<AccountType> AccountTypes { get; set; }

        public virtual ICollection<Pescription> Pescriptions { get; set; }


    }
}
