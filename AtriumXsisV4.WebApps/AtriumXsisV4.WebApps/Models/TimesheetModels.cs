using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtriumXsisV4.WebApps.Models
{
    public class TimesheetModels
    {
        public TimesheetModels()
        {

        }

        public Guid ID { get; set; }
        public string EMPLOYEEID { get; set; }
        public DateTime DWORKDATE { get; set; }
        public string VSTATUS { get; set; }
        public DateTime? DSTARTWORK { get; set; }
        public DateTime? DENDWORK { get; set; }
        public DateTime? DSTARTOT { get; set; }
        public DateTime? DENDOT { get; set; }
        public string DESCRIPTION { get; set; }
        public DateTime? DCREA { get; set; }
        public string VCREA { get; set; }
        public DateTime? DMODI { get; set; }
        public string VMODI { get; set; }
    }
}