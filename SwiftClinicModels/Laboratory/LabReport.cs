using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwiftClinicModels.Laboratory
{
    public class LabReport
    {
        [Key, ForeignKey("LabTestRequest")]
        public int LabTestRequestId { get; set; }
        public string DocumentType { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string FileLocation { get; set; }
        public bool IsDone { get; set; }
        public DateTime ReportDate { get; set; }
        public virtual LabTestRequest LabTestRequest { get; set; }
    }
}
