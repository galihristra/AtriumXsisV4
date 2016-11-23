using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtriumXsisV4.WebApps.Models
{
    public class ProjectModels
    {
        public ProjectModels()
        {

        }

        public string PROJECTID { get; set; }
        public string VCLNAME { get; set; }
        public string VCLADDRESS { get; set; }
        public DateTime? DCREA { get; set; }
        public string VCREA { get; set; }
        public DateTime? DMODI { get; set; }
        public string VMODI { get; set; }
    }
}