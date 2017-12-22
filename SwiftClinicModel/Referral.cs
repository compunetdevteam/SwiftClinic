﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwiftClinicModel;

namespace BinghamWebApp.Models
{
    public class Referral
    {
        public int ReferralID { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "The Date is required")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name = "From Clinic")]
        [Required(ErrorMessage = "Your Clinic name is required")]
        public PopUp.Clinic FromClinic { get; set; }

        [Display(Name = "Referring Doctor")]
        [Required(ErrorMessage = "Your Clinic name is required")]
        public string StaffNumber { get; set; }

        [Display(Name = "To Clinic")]
        [Required(ErrorMessage = "Your Clinic name is required")]
        public PopUp.Clinic ToClinic { get; set; }

        [Display(Name = "Subject")]
        [Required(ErrorMessage = "Subject is required")]
        [StringLength(25, ErrorMessage = "Treatment is too long")]        
        public string Subject { get; set; }

        [Display(Name = "Remark / Special Instructions")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Message is required")]
        [StringLength(200, ErrorMessage = "Message is too long")]
        public string Message { get; set; }

        [Display(Name = "Patient ID")]
        [Required]
        [Range(0, 100000)]
        public int PatientNumber { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
