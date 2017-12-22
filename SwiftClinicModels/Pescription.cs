using SwiftClinicModels.Pharmacy;
using System;
using System.ComponentModel.DataAnnotations;

namespace SwiftClinicModels
{
    public class Pescription
    {
        public int PescriptionId { get; set; }

        public int ConsultantRecordId { get; set; }

        public int DrugId { get; set; }

        [Display(Name = "Drug Name")]
        public string DrugName { get; set; }

        public int DosageId { get; set; }
        public int Quantity { get; set; }
        public string DosageNote { get; set; }

        public string Duration { get; set; }

        public DateTime Date { get; set; }

        public virtual ConsultantRecord ConsultantRecord { get; set; }
        public virtual Dosage Dosage { get; set; }
        public virtual Drug Drug { get; set; }

    }
}