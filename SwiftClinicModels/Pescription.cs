using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using SwiftClinicModels;

namespace BinghamWebApp.Models
{
    public class Pescription
    {
        public int PescriptionID { get; set; }

        public int PatientNumber { get; set; }

        public string DrugName { get; set; }

        public string Dose { get; set; }

        public string Duration { get; set; }

        public DateTime Date { get; set; }
   
        public virtual Patient Patients { get; set; }

    }
}