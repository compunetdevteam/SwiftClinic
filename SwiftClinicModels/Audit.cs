using System;

namespace SwiftClinicModels
{
    public class Audit
    {
        // Audit Properties
        public string SessionId { get; set; }
        public Guid AuditId { get; set; }
        public string UserName { get; set; }
        public string IpAddress { get; set; }
        public string UrlAccessed { get; set; }
        public DateTime TimeAccessed { get; set; }
        public string Data { get; set; }

        // Default Constructor
        public Audit() { }
    }
}
